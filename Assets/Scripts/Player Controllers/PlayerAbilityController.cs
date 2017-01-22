using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerAbilityController : MonoBehaviour {

    // Core components
    public Projectile ProjectilePrefab;
    
    // Projectile parameters
    public float FireColdown = 1.0f;
    private bool inColdown = false;
    public int MaxProjectileBounces = 10;
    public float MinProjectileSpeed = 5.0f;
    public float MaxProjectileSpeed = 10.0f;

    // Charging parameters
    public float ChargingSpeed = 1.0f;
    public int MaxProjectileLevel = 5;
    [SerializeField]
    private float currentProjectileLevel = 0;

    // Core references
    private List<Projectile> currentProjectileList = new List<Projectile>(); 
    private PlayerController playerController;

    // Special Abilities
    public float ForceRange = 10;
    public float ForceStrenght = 10;

    // VFX
    public Renderer VfxRenderer;
    public float VfxDuration = 1.0f;
    private bool inForceColdown = false;
    public float ForceColdown = 1.5f;
    public float RepulseScale = 10.0f;
    public float RefractionIntensity = 0.2f;

    private enum ForcePower
    {
        Attract,
        Repel,
    }

    public void Initialize(PlayerController controller)
    {
        // Store initial references
        playerController = controller;
    }

    void OnDrawGizmosSelected()
    {
        // Display the explosion radius when selected
        Gizmos.color = new Color(1, 1, 0, 0.75F);
        Gizmos.DrawWireSphere(transform.position, this.ForceRange);
    }

    private void ExecuteForcePower(ForcePower power)
    {
        Collider[] hitColliders = Physics.OverlapSphere(this.transform.position, ForceRange);
        foreach (var collider in hitColliders)
        {
            MovableEntity entity = collider.GetComponentInChildren<MovableEntity>();
            if (entity != null)
            {
                Vector3 movementVector = Vector3.zero;
                if (power == ForcePower.Repel)
                    movementVector = entity.transform.position - this.transform.position;
                else
                    movementVector = this.transform.position - entity.transform.position;

                entity.UpdateMovementVector(movementVector.normalized  * ForceStrenght);
            }
        }

    }

    public void UpdatePlayerAbility(InputInstance playerInput)
    {
        // Repulse
        if (!inForceColdown && playerInput.Repel)
        {
            VfxRenderer.material.SetFloat("_RefractionIntensity",RefractionIntensity);
            
            VfxRenderer.gameObject.transform.DOKill();
            VfxRenderer.gameObject.transform.localScale = Vector3.zero;
            VfxRenderer.gameObject.transform.DOScale(Vector3.one*RepulseScale, VfxDuration);
            VfxRenderer.material.DOFloat(0.0f, "_RefractionIntensity", VfxDuration);

            ExecuteForcePower(ForcePower.Repel);

            // Start coldown
            StartCoroutine("ExecuteForceColdown");
        }

        // Attact 
        if (!inForceColdown && playerInput.Attract)
        {
            VfxRenderer.material.SetFloat("_RefractionIntensity", RefractionIntensity);

            VfxRenderer.gameObject.transform.DOKill();
            VfxRenderer.gameObject.transform.localScale = Vector3.one * RepulseScale;
            VfxRenderer.gameObject.transform.DOScale(0.0f, VfxDuration);
            VfxRenderer.material.DOFloat(0.0f, "_RefractionIntensity", VfxDuration);

            ExecuteForcePower(ForcePower.Attract);

            // Start coldown
            StartCoroutine("ExecuteForceColdown");
        }
        // Fire Projectile
        if (!inColdown && playerController.CanFire)
        {
            // Charge projectile
            if (playerInput.FireCharging)
            {
                ChargeProjectile();
            }
            // Fire projectile
            else if (playerInput.FireRelease)
            {
                FireProjectile();
            }
        }
    }

    public void Reset()
    {
        // Reactivate shields
        playerController.ShieldController.ManageShields(true);

        // Reset projectile level
        currentProjectileLevel = 0;
    }

    private void ChargeProjectile()
    {
        // Deactivate shields
        playerController.ShieldController.ManageShields(false);

        // Update current projectile level
        currentProjectileLevel += ChargingSpeed * Time.deltaTime;
        currentProjectileLevel = Mathf.Clamp(currentProjectileLevel, 0, MaxProjectileLevel);
    }

    private void FireProjectile()
    {
        // Fire projectile
        Projectile newProjectile = Instantiate(ProjectilePrefab.gameObject,
            playerController.ShieldController.ShieldObject.transform.position,
            playerController.ShieldController.ShieldObject.transform.rotation).GetComponent<Projectile>();

        // Get target values
        float targetSpeed = Mathf.Lerp(MinProjectileSpeed, MaxProjectileSpeed, currentProjectileLevel/MaxProjectileLevel);

        // Initialize projectile
        newProjectile.Initialize(playerController,targetSpeed);

        // Remove null objects
        currentProjectileList.RemoveAll(item => item == null);

        // Add to list
        currentProjectileList.Add(newProjectile);

        // Start coldown
        StartCoroutine("ExecuteFireColdown");

        // Reactivate shields
        Reset();
    }

    IEnumerator ExecuteFireColdown()
    {
        inColdown = true;
        yield return new WaitForSeconds(this.FireColdown);
        inColdown = false;
    }

    IEnumerator ExecuteForceColdown()
    {
        inForceColdown = true;
        yield return new WaitForSeconds(this.ForceColdown);
        inForceColdown = false;
    }
}

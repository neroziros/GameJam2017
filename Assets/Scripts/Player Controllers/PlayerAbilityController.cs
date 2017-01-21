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

    // VFX
    public Renderer VfxRenderer;
    public float VfxDuration = 1.0f;
    public float RepulseScale = 10.0f;

    public void Initialize(PlayerController controller)
    {
        // Store initial references
        playerController = controller;
    }

    public void UpdatePlayerAbility(InputInstance playerInput)
    {
        // Repulse
        if (playerInput.Repel)
        {
            VfxRenderer.gameObject.transform.DOKill();
            VfxRenderer.gameObject.transform.localScale = Vector3.zero;
            VfxRenderer.gameObject.transform.DOScale(Vector3.one*RepulseScale, VfxDuration);
        }

        // Attact 
        // todo:

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
}

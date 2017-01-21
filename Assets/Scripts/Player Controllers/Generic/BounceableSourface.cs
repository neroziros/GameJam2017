using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BounceableSourface : MonoBehaviour
{
    // Core references
    private PlayerController controller;
    private Collider collider;

    private void Awake()
    {
        collider = GetComponentInChildren<Collider>();
    }

    public void Initialize(PlayerController playerController)
    {
        // Store core components
        controller = playerController;
    }
    
    private void ProcessIncomingProjectile(Projectile projectile, Vector3 collisionVector)
    {
        // Execute damage to missile
        projectile.DealDamage(1);

        // If it is still alive, bounce the object
        if (projectile.IsAlive)
        {
            RaycastHit[] hits;
            hits = Physics.RaycastAll(projectile.transform.position, collisionVector, Mathf.Infinity);
            for (int i = 0; i < hits.Length; i++)
            {
                if (hits[i].collider == this.collider)
                {
                    projectile.UpdateMovementVector(Vector3.Reflect(collisionVector, hits[i].normal));
                    return;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Projectile incomingProjectile = other.GetComponentInChildren<Projectile>();
        if (incomingProjectile != null)
        {
            bool isSamePlayerAndNotEnoughBounces = controller == incomingProjectile.OriginPlayer &&
                                                   incomingProjectile.currentBounceAmount <= 0;
            if (!isSamePlayerAndNotEnoughBounces)
            {
                Vector3 collisionVector = (this.transform.position - other.transform.position).normalized;
                ProcessIncomingProjectile(incomingProjectile, collisionVector);
            }
        }
    }
}

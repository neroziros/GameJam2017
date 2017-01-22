using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BounceableSourface : MonoBehaviour
{
    // Core references
    private PlayerController controller;
    private Collider collider;

    // Events
    private Action OnCollision;

    private void Awake()
    {
        collider = GetComponentInChildren<Collider>();
    }

    public void Initialize(PlayerController playerController, Action onCollision)
    {
        // Store core components
        controller = playerController;
        this.OnCollision = onCollision;
    }
    
    private void ProcessIncomingProjectile(Projectile projectile, Vector3 collisionVector)
    {
        // Execute damage to missile
        projectile.DealDamage(1);
        BaseSoundManager.Instance.PlaySoundByIndex(3, this.transform.position);

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

                if (OnCollision != null)
                    OnCollision();
            }
        }
    }
}

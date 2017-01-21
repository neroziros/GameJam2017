using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MovableEntity
{
    // Core parameters
    public float LifeTime = 30.0f;
    private bool isInitialized = false;

    private float movementSpeed;

    public void Initialize(float speed)
    {
        // Set control parameters
        movementSpeed = speed;

        // Start lifetime
        StartCoroutine("UpdateLifetime");

        // Mark initialization finished
        isInitialized = true;
    }

    /// <summary>
    /// Update this instance
    /// </summary>
    private void Update()
    {
        if(!isInitialized)return;

        transform.position += transform.forward * Time.deltaTime * movementSpeed;

    }

    IEnumerator UpdateLifetime()
    {
        yield return new WaitForSeconds(this.LifeTime);
        Destroy(this.gameObject);
    }
}


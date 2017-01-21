using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MovableEntity
{
    // Core parameters
    public float LifeTime = 30.0f;
    [System.NonSerialized]
    public PlayerController OriginPlayer;

    private bool isInitialized = false;
    private float movementSpeed;

    public void Initialize(PlayerController controller, float speed)
    {
        // Set control parameters
        OriginPlayer = controller;
        movementSpeed = speed;

        // Start lifetime
        StartCoroutine("UpdateLifetime");

        // Mark initialization finished
        isInitialized = true;
    }

    public override void Kill()
    {
        StopCoroutine("UpdateLifetime");
        base.Kill();
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


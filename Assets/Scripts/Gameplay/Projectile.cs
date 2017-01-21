using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MovableEntity
{
    // Core parameters
    public float LifeTime = 30.0f;

    public void Initialize()
    {
        //  Start lifetime
        StartCoroutine("UpdateLifetime");
    }

    /// <summary>
    /// Update this instance
    /// </summary>
    private void Update()
    {
        
    }

    IEnumerator UpdateLifetime()
    {
        yield return new WaitForSeconds(this.LifeTime);
        Destroy(this.gameObject);
    }
}


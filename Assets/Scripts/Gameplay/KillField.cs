using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillField : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        MovableEntity incomingProjectile = other.GetComponentInChildren<MovableEntity>();
        if (incomingProjectile != null)
        {
            incomingProjectile.Kill();
        }
    }
}

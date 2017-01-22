using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableEntity : Entity
{
    public int currentBounceAmount = 0;

    public virtual void UpdateMovementVector(Vector3 redirectionTarget, bool wasABounces = true)
    {
        redirectionTarget.y = 0;
        transform.rotation = Quaternion.LookRotation(redirectionTarget);
        if (wasABounces)
            currentBounceAmount++;
    }
}

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class Entity : MonoBehaviour {
    // Player status
    [Header("Player Status")]
    public int HitPoints = 1;
    public bool IsAlive { get { return this.HitPoints >= 1; } }

    public virtual void ChangeRole( bool respawn = false)
    {
        // todo: if required
    }
    
    public virtual void Resurrect()
    {
        this.gameObject.SetActive(true);

        // Restore health points
        this.HitPoints = 1;
    }

    public virtual void Kill()
    {
        Debug.Log(this.gameObject.name + " is DEAD!");

        // Remove health points
        this.HitPoints = 0;

        // Deactivate unit
        this.gameObject.SetActive(false);

    }
}

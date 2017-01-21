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

    public virtual void DealDamage(int damage)
    {
        // Deal damage
        HitPoints = Mathf.Max(HitPoints - damage, 0);

        // Check if we died
        if(!IsAlive)
            Kill();
    }

    public virtual void ReactGameplayCollision(Entity entity)
    {}

    public virtual void Resurrect()
    {}

    public virtual void Kill()
    {
        Destroy(this.gameObject);
    }
}

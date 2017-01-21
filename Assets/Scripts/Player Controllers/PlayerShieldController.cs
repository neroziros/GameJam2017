using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class PlayerShieldController : MonoBehaviour
{
    // Core parameters
    public GameObject ShieldObject;
    public Vector3 minScale = Vector3.one * 0.5f;
    public Vector3 maxScale = Vector3.one;

    // Core references
    private BounceableSourface surface;

    public void Initialize(PlayerController playerController)
    {
        // Store core components
        surface = this.GetComponentInChildren<BounceableSourface>();
        surface.Initialize(playerController);
    }

    public void ManageShields(bool state)
    {
        ShieldObject.transform.localScale = state ? maxScale : minScale;
    }

    public void UpdateShieldInput(InputInstance playerInput)
    {
        // Generate new target
        Vector3 m_TargetWorldPos = new Vector3(playerInput.HorizontalLook, 0, playerInput.VerticalLook);

        // Check if we must move
        if (m_TargetWorldPos.magnitude == 0)
            return;

        m_TargetWorldPos = Camera.main.transform.TransformDirection(m_TargetWorldPos);
        m_TargetWorldPos.y = 0;

        transform.parent.rotation = Quaternion.LookRotation(m_TargetWorldPos);
    }
}

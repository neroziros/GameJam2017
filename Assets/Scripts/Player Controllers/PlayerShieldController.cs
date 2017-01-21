using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShieldController : MonoBehaviour {

    public void Initialize(PlayerController playerController)
    {
        
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

        transform.rotation = Quaternion.LookRotation(m_TargetWorldPos);
    }
}

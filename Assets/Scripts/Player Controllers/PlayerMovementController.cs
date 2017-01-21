using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float MaxSpeed = 1.0f;

    public void Initialize(PlayerController playerController)
    {}

    public void UpdateMovement(InputInstance playerInput)
    {
        // Generate new target
        Vector3 m_TargetWorldPos = new Vector3(playerInput.StrafeRight, 0, playerInput.MoveForward);

        // Check if we must move
        if (m_TargetWorldPos.magnitude == 0)
            return;

        m_TargetWorldPos = Camera.main.transform.TransformDirection(m_TargetWorldPos);

        m_TargetWorldPos.y = 0;
        transform.Translate(m_TargetWorldPos.normalized  * MaxSpeed * Time.deltaTime);


        /*
        // Check if the player has moved
        if (playerInput.MoveForward == 0 && playerInput.StrafeRight == 0)
            return;

        // Construct the proper target vector
        m_TargetWorldPos = new Vector3(playerInput.MoveForward, 0, playerInput.StrafeRight);
        Debug.Log(m_TargetWorldPos);
        
        // Get the required speed for this movement
        m_CurrentSpeed = (MaxMovementSpeed) * Mathf.Clamp(Vector3.Distance(transform.position, m_TargetWorldPos) / maxSpeedDistance, 0, 1);

        // Get the normalized player direction
        m_MoveDirection = GetTargetDirection(m_TargetWorldPos).normalized;
        m_MoveDirection.y = 0;

        // Check if the player can move to the desired position
        //if(!m_Collision.canMoveTo(transform.position + m_MoveDirection * m_CharController.radius))return false;

        // Try to move the character to the desired position
        m_CharController.Move(m_MoveDirection * m_CurrentSpeed * Time.deltaTime);
        */
    }

    public void Stop()
    {
        // todo:
    }
    
    /// <summary>
    /// Gets the  target direction (using the player as origin point)
    /// </summary>
    /// <param name="TargetPos"></param>
    /// <returns></returns>
    public Vector3 GetTargetDirection(Vector3 TargetPos)
    {
        return TargetPos - transform.position;
    }
}

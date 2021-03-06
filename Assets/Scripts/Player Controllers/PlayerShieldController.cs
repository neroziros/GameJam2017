﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class PlayerShieldController : MonoBehaviour
{
    // Core parameters
    public GameObject ShieldObject;
    public float ShieldStunDuration = 0.5f;
    public GameObject ChargingParticleSystem;

    // Core references
    private PlayerController controller;
    private BounceableSourface surface;

    public void Initialize(PlayerController playerController)
    {
        // Store core components
        controller = playerController;
        surface = this.GetComponentInChildren<BounceableSourface>();
        surface.Initialize(playerController, OnShieldCollision);
    }

    public void OnShieldCollision()
    {
        BaseSoundManager.Instance.PlaySoundByIndex(3, this.transform.position);

        StopCoroutine("ExecuteShieldStun");
        StartCoroutine("ExecuteShieldStun");
    }


    IEnumerator ExecuteShieldStun()
    {
        if (controller.State == PlayerController.PlayerState.Normal)
        {
            controller.State = PlayerController.PlayerState.Stunned;
            ShieldObject.gameObject.SetActive(false);

            yield return new WaitForSeconds(ShieldStunDuration);

            controller.State = PlayerController.PlayerState.Normal;
            ShieldObject.gameObject.SetActive(true);
        }
    }


    public void ManageShields(bool state)
    {
        ChargingParticleSystem.SetActive(!state);
        ShieldObject.SetActive(state);
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

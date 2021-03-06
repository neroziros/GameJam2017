﻿using System;
using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.SceneManagement;
using DG.Tweening;

/// <summary>
/// Manages the player status
/// </summary>
public class PlayerController : MovableEntity
{
    // Core presenter
    private PlayerPresenter playerPresenter;

    // Main player identifier
    public ID PlayerId = ID.Player1;
    [System.NonSerialized]
    public int PlayerIndex = -1;

    // Main controllers
    public PlayerInput InputController { get; private set; }
    public PlayerShieldController ShieldController { get; private set; }
    public PlayerMovementController MovementController { get; private set; }
    public PlayerCameraController CameraController { get; private set; }
    public AvatarController[] PlayerAvatarControllers = new AvatarController[4];
    public AudioController PlayerAudioController { get; private set; }
    public PlayerAbilityController PlayerAbilityController { get; private set; }

    // Collisions
    public LayerMask GameplayLayerMask;
    public float DisplacementDurations = 0.5f;

    // General state
    private PlayerState _state = PlayerState.Normal;

    public PlayerState State
    {
        get { return _state; }
        set
        {
            _state = value;
            PlayerAbilityController.Reset();
        }
    }
    public bool CanMove
    {
        get { return State != PlayerState.Displacement; }
    }
    public bool CanFire
    {
        get { return State == PlayerState.Normal; }
    }


    public override void UpdateMovementVector(Vector3 redirectionTarget, bool wasABounces = true)
    {
        State = PlayerState.Displacement;
        transform.DOMove(transform.position + redirectionTarget, this.DisplacementDurations).OnComplete(() =>
        {
            State = PlayerState.Normal;
        });
    }

    // Initialize this class
    public void Initialize(PlayerPresenter playerPresenter,int index)
	{
        // Set player identifier
        this.PlayerId = (ID) index;
        this.PlayerIndex = index;
        this.transform.name = this.PlayerId.ToString();
        this.MaxHitPoints = this.HitPoints;

        // Set initial player variables
        this.playerPresenter = playerPresenter;

        this.InputController = this.GetComponentInChildren<PlayerInput>();
        this.MovementController = this.GetComponentInChildren<PlayerMovementController>();
        this.CameraController = this.GetComponentInChildren<PlayerCameraController>();
        this.PlayerAudioController = this.GetComponentInChildren<AudioController>();

        this.ShieldController = this.GetComponentInChildren<PlayerShieldController>();
        this.PlayerAbilityController = this.GetComponentInChildren<PlayerAbilityController>();

        // Initialize player components
        //this.PlayerAudioController.Initialize();
        this.InputController.Initialize(this);
        this.MovementController.Initialize(this);
        this.ShieldController.Initialize(this);
        this.PlayerAbilityController.Initialize(this);
        //this.CameraController.Initialize(this, cameraConfiguration);
        //this.PlayerAvatarController.Initialize(this);
        //this.PlayerUIPresenter.Initialize(this);

        // Display proper avatar
        foreach (var avatar in PlayerAvatarControllers)
        {
            avatar.gameObject.SetActive(false);
        }
        PlayerAvatarControllers[index].gameObject.SetActive(true);
        PlayerAvatarControllers[index].Initialize(this);

    }

    #region Player Components Update
    // Update is called once per frame
    void Update()
    {
        if (GamePresenter.Instance.CurrentMatchState != GamePresenter.State.Running)
            return;

        // Update player input given the current input key configuration
        this.InputController.UpdateInput();

        // Update regular controllers
        this.UpdateControllers();
    }

    // FixedUpdate is called once per physics frame
    void FixedUpdate()
    {
        // Update physics related controllers
        this.FixedUpdateControllers();
    }

    // Update player controllers every frame
    private void UpdateControllers()
    {
        // Update controlers using updated player input if required
        // this.CameraController.UpdateCamera(this.InputController.InputInstance);
        this.MovementController.UpdateMovement(this.InputController.InputInstance);
        this.ShieldController.UpdateShieldInput(this.InputController.InputInstance);
        this.PlayerAbilityController.UpdatePlayerAbility(this.InputController.InputInstance);
        this.PlayerAvatarControllers[this.PlayerIndex].UpdateAvatar(this.InputController.InputInstance);

    }

    // Update player controllers every physics frame
    private void FixedUpdateControllers()
    {
        // Update controlers using updated player input if required
        // note: there is no need to update the input here since it only changes between update frames
        // this.MovementController.FixedUpdateMovement(this.InputController.InputInstance);
    }
    #endregion

    #region Player Events

    public override void Resurrect()
    {
        // Reactivate gameobject
        this.gameObject.SetActive(true);

        // Restore health points
        this.HitPoints = 1;

        // Stop player
        this.MovementController.Stop();
    }

    public override void Kill()
    {
        // Stop player
        this.MovementController.Stop();

        // Remove health points
        this.HitPoints = 0;

        // Deactivate unit
        this.gameObject.SetActive(false);

        // Destroy all his proyectiles
        // todo:
    }

    #endregion

    #region Collisions
    public void ReactGameplayCollision(Projectile projectile)
    {
        // Only react to the entity if it's alive
        if (!this.IsAlive || GamePresenter.Instance.CurrentMatchState != GamePresenter.State.Running)
            return;

        // Safety check for stupid stuff
        bool isSamePlayerAndNotEnoughBounces = this == projectile.OriginPlayer &&
                                       projectile.currentBounceAmount <= 0;
        if (isSamePlayerAndNotEnoughBounces)
            return;

        BaseSoundManager.Instance.PlaySoundByIndex(this.PlayerAvatarControllers[this.PlayerIndex].AudioIndexes[(int)AvatarController.AudioIndexesEnum.Hit], this.transform.position);

        // Reduce player health point
        this.DealDamage(1);

        // Execute avatar animation
        this.PlayerAvatarControllers[this.PlayerIndex].OnHit();
        
        // Kill projectile
        projectile.DealDamage(projectile.HitPoints);
    }

    private void OnTriggerEnter(Collider other)
    {
        Projectile incomingProjectile = other.GetComponentInChildren<Projectile>();
        if (incomingProjectile != null)
        {
            Vector3 collisionVector = (this.transform.position - other.transform.position).normalized;
            ReactGameplayCollision(incomingProjectile);
        }
    }

    #endregion
    public enum PlayerState
    {
        Normal,
        Stunned,
        Displacement,
    }
    public enum ID
    {
        Player1,
        Player2,
        Player3,
        Player4
    }

}
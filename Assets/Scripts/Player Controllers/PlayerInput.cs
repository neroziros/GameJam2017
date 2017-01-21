using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/// <summary>
/// Manages the player input and sends it to the player components
/// </summary>
public class PlayerInput : MonoBehaviour
{
    // Component references
    private PlayerController mainPlayerController;

    // Player configuration
    [Header("Player Controls")]
    public InputInstance.InputConfiguration InputConfiguration;

    public InputInstance InputInstance { get; private set; }

    public void Initialize(PlayerController playerController)
    {
        // Store references
        this.mainPlayerController = playerController;

        // Initialize input class
        this.InputInstance = new InputInstance();
    }

    public void UpdateInput()
    {
        // Update input
        this.InputInstance.Update(this.InputConfiguration);
    }
}

/// <summary>
/// This class manages the player input
/// </summary>
public class InputInstance
{
    public InputConfiguration Config;

    public float MoveForward;
    public float StrafeRight;

    public float VerticalLook;
    public float HorizontalLook;

    public bool FireCharging;
    public bool FireRelease;

    public bool Attract;
    public bool Repel;

    public bool Debugging = false;

    public void Update(InputConfiguration config)
    {
        this.Config = config;

        // General input
        this.HorizontalLook = Input.GetAxisRaw(config.HorizontalInput);
        this.VerticalLook = Input.GetAxisRaw(config.VerticalInput);

        // Keyboard input
        if (this.Config.TControlType == ControlType.Keyboard)
        {
            this.MoveForward = Input.GetKey(config.MoveForward) ? 1 : 0;
            this.MoveForward = Input.GetKey(config.MoveBack) ? -1 : this.MoveForward;

            this.StrafeRight = Input.GetKey(config.StrafeRight) ? 1 : 0;
            this.StrafeRight = Input.GetKey(config.StrafeLeft) ? -1 : this.StrafeRight;
            
            this.FireCharging = Input.GetKey(config.Fire);

            this.Attract = Input.GetKey(config.Attract);
            this.Repel = Input.GetKeyDown(config.Repel);
        }
        // Gamepad input
        else
        {
            this.MoveForward = Input.GetAxisRaw(config.GamepadVerticalInput);
            this.StrafeRight = Input.GetAxisRaw(config.GamepadHorizontalInput);

            this.FireCharging = Input.GetKey(config.GamepadFire);
            this.FireRelease = Input.GetKeyUp(config.GamepadFire);
            /*
            this.Attract = Input.GetAxisRaw(config.GamepadAttract) > 0;
            this.Repel = Input.GetAxisRaw(config.GamepadRepel) > 0;
            */
            if (Debugging)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        if (Input.GetKeyDown("joystick " + j + " button " + i))
                        {
                            Debug.Log("joystick " + j + " button " + i);
                        }
                    }
                }
            }

        }
    }

    [System.Serializable]
    public class InputConfiguration
    {
        [Header("General")]
        public ControlType TControlType = ControlType.Keyboard;

        [Header("Directional Movement")]
        public KeyCode MoveForward = KeyCode.W;
        public KeyCode MoveBack = KeyCode.S;
        public KeyCode StrafeLeft = KeyCode.A;
        public KeyCode StrafeRight = KeyCode.D;

        public string GamepadFire = "joystick 1 button 0";
        public string GamepadAttract = "joystick 1 button 1";
        public string GamepadRepel = "joystick 1 button 2";

        [Header("Gamepad Movement Axes")]
        public string GamepadHorizontalInput = "Mouse X";
        public string GamepadVerticalInput = "Mouse Y";

        [Header("Controller Camera Axes")]
        public string HorizontalInput = "Mouse X";
        public string VerticalInput = "Mouse Y";

        [Header("Special Movement Actions")]
        public KeyCode Fire = KeyCode.LeftShift;
        public KeyCode Attract = KeyCode.LeftControl;
        public KeyCode Repel = KeyCode.Space;
    }

    public enum ControlType
    {
        Keyboard,
        Gamepad
    }
}

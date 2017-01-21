using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PlayerPresenter : MonoBehaviour {

    // Core component references
    private EnvironmentPresenter environmentPresenter;

    // Player references
    public PlayerController[] Players { get; private set;}

    // Player respawn variables
    [Header("Player Respawn")]
    [Range(0,2)]
    public float SafetyOffset = 1.0f;
    [Range(0,10)]
    public float RespawnDelay = 2.0f;
    // Player prefab
    [Header("Player Setup")]
    public PlayerController PlayerPrefab;
    [Range(2,4)]
    public int PlayerAmount = 4;
    public int KeyboardPlayerIndex = -1;

    // Player parent
    public Transform FourPlayersParent;

    // Input configurations
    [Header("Input Configurations")]
    public InputInstance.InputConfiguration ConfigKeyboard;
    public InputInstance.InputConfiguration ConfigGamepad1;
    public InputInstance.InputConfiguration ConfigGamepad2;
    public InputInstance.InputConfiguration ConfigGamepad3;
    public InputInstance.InputConfiguration ConfigGamepad4;


    // Use this for initialization
    public void Initialize (EnvironmentPresenter environmentPresenter) {
        // Store environment presenters
	    this.environmentPresenter = environmentPresenter;

        // Create Players
        this.CreatePlayers();

        // If it's a valid value, create the keyboard player
        if (this.KeyboardPlayerIndex >= 0 && this.KeyboardPlayerIndex < this.PlayerAmount)
            this.Players[this.KeyboardPlayerIndex].InputController.InputConfiguration = this.ConfigKeyboard;

        // Set initial random player positions
	    Transform[] initialTransforms = this.environmentPresenter.GetPossibleSpawnPoints();
	    if (initialTransforms != null && this.Players.Length <= initialTransforms.Length)
	    {
	        for (int index = 0; index < this.Players.Length; index++)
	        {
	            var player = this.Players[index];
                this.SetPlayerPosition(player, initialTransforms[index]);
            }
        }
    }

    private void CreatePlayers()
    {
        this.Players = new PlayerController[this.PlayerAmount];
        for (int i = 0; i < this.PlayerAmount; i++)
        {
            this.Players[i] = Instantiate(this.PlayerPrefab);
            this.Players[i].transform.parent = this.FourPlayersParent;
        }

        // Initialize all Players
        for (int index = 0; index < this.Players.Length; index++)
        {
            var player = this.Players[index];

            // Initialize player
            player.Initialize(this,index);

            // Assign its control configuration
            switch (index)
            {
                case 0:
                    player.InputController.InputConfiguration = this.ConfigGamepad1;
                    break;
                case 1:
                    player.InputController.InputConfiguration = this.ConfigGamepad2;
                    break;
                case 2:
                    player.InputController.InputConfiguration = this.ConfigGamepad3;
                    break;
                case 3:
                    player.InputController.InputConfiguration = this.ConfigGamepad4;
                    break;
            }
        }
    }

    // Update is called once per frame
	void Update ()
    {
        //todo:
    }

    #region Respawing
    public void RequestPlayerRespawn(PlayerController playerToRespawn)
    {
        // Check if the player is registered
        if (this.Players.Contains(playerToRespawn))
            StartCoroutine("DelayedRespawn", playerToRespawn);
    }

    IEnumerator DelayedRespawn(PlayerController player)
    {
        // Wait the respawn coldown
        yield return new WaitForSeconds(this.RespawnDelay);

        this.RespawnPlayer(player);
    }

    private void RespawnPlayer(PlayerController player)
    {
        Debug.Log("Respawning Player: " + player.name);

        // Move player to valid respawn location
        Transform spawnTransform = this.environmentPresenter.GetValidPlayerSpawnTransform();
        this.SetPlayerPosition(player, spawnTransform);

        // Restore player stats
        player.Resurrect();

        // Play wolf sfx
        GamePresenter.Instance.AudioPresenter.PlayHowlSFX();

    }

    private void SetPlayerPosition(PlayerController player, Transform spawnTransform)
    {
        player.transform.position = spawnTransform.position;
        player.transform.rotation = spawnTransform.rotation;
        player.transform.position += Vector3.up*this.SafetyOffset;
    }

    #endregion

}

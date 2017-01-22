using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AvatarController : MonoBehaviour {

    // Component references
    private PlayerController mainPlayerController;

    // Possible Avatars
    public Animator CoreAvatar;
    public SpriteRenderer CoreImage;
    private bool isInitialized = false;

    public Sprite RegularSprite;
    public Sprite DedSprite;

    // Configurable animations
    public enum AudioIndexesEnum
    {
        Attack,
        Hit,
    }
    public int[] AudioIndexes = new int[2]; 

    // Use this for initialization
    public void Initialize (PlayerController playerController) {
        // Store main player component reference
        this.mainPlayerController = playerController;
        isInitialized = true;
    }

    public void UpdateAvatar(InputInstance input)
    {
        // Update orientation
        if (input.StrafeRight > 0)
        {
            CoreImage.flipX = false;
        }
        else if (input.StrafeRight < 0)
        {
            CoreImage.flipX = true;
        }

        // Update movement
        if (input.StrafeRight != 0 || input.MoveForward != 0)
        {
            CoreAvatar.SetBool("Moving",true);
        }
        else
        {
            CoreAvatar.SetBool("Moving", false);
        }
    }

    public void OnHit()
    {
        CoreAvatar.SetTrigger("hit");
    }
    
    private void Update()
    {
        if(!isInitialized)
            return;
    }
}

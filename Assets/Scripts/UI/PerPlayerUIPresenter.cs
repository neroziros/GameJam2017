using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PerPlayerUIPresenter : MonoBehaviour
{
    public Image Health;
    public Image CharacterIcon;
    public float AnimationLenght = 0.35f;

    private int oldHealth = -1;
    private PlayerController _playerController;

    public void Initialize(PlayerController playerController)
    {
        _playerController = playerController;

        CharacterIcon.sprite = playerController.PlayerAvatarControllers[playerController.PlayerIndex].RegularSprite;

        oldHealth = _playerController.HitPoints;
    }

    private void Update()
    {
        // Update health
        if (oldHealth > _playerController.HitPoints)
        {
            oldHealth = _playerController.HitPoints;

            this.Health.DOKill();

            this.Health.DOFillAmount((float) this._playerController.HitPoints/this._playerController.MaxHitPoints,
                AnimationLenght);
        }

        if (!_playerController.IsAlive)
        {
            CharacterIcon.sprite = _playerController.PlayerAvatarControllers[_playerController.PlayerIndex].DedSprite;
        }
    }
}

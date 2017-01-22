using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PerPlayerUIPresenter : MonoBehaviour
{
    public Image Health;
    public float AnimationLenght = 0.35f;

    private int oldHealth = -1;
    private PlayerController _playerController;

    public void Initialize(PlayerController playerController)
    {
        _playerController = playerController;

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
    }
}

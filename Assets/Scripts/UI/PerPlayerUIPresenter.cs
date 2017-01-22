using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerPlayerUIPresenter : MonoBehaviour
{
    public Image Health;

    private PlayerController _playerController;

    public void Initialize(PlayerController playerController)
    {
        _playerController = playerController;
    }

    private void Update()
    {
        // Update health
        this.Health.fillAmount = (float)this._playerController.HitPoints/this._playerController.MaxHitPoints;
    }
}

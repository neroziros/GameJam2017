using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreUIPresenter : MonoBehaviour {

    public PerPlayerUIPresenter[] PlayerUIPresenter = new PerPlayerUIPresenter[4]; 

    // Use this for initialization
    public void Initialize()
    {
        foreach (var presenter in PlayerUIPresenter)
        {
            presenter.gameObject.SetActive(false);
        }

        for (int i = 0; i < GamePresenter.Instance.PlayerPresenter.PlayerAmount; i++)
        {
            PlayerUIPresenter[i].gameObject.SetActive(true);
            PlayerUIPresenter[i].Initialize(GamePresenter.Instance.PlayerPresenter.Players[i]);
        }
    }
}

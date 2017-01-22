using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WallSetPresenter : MonoBehaviour
{
    public float FinalHeight = 1.0f;
    public float InitialHeight = -1.0f;

    public float AnimationLenght = 1.0f;

    public void Display()
    {
        this.transform.position = new Vector3(this.transform.position.x, InitialHeight,this.transform.position.z); ;
        this.transform.DOLocalMoveY(FinalHeight, AnimationLenght).SetEase(Ease.OutElastic);
    }

    public void Hide()
    {
        this.transform.position = new Vector3(this.transform.position.x, FinalHeight, this.transform.position.z); ;
        this.transform.DOLocalMoveY(InitialHeight, AnimationLenght);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreen : MonoBehaviour {

    public Animator[] CharactersAnimators = new Animator[4];
    
    public void DisplayWinScreen(int winnerIndex)
    {
        for (int index = 0; index < CharactersAnimators.Length; index++)
        {
            CharactersAnimators[index].SetBool("win", index == winnerIndex);
        }    
    }

    public void GotToMainMenu()
    {
        
    }

    public void Restart()
    {
        
    }
}

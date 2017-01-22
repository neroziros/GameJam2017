using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene("Menu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}

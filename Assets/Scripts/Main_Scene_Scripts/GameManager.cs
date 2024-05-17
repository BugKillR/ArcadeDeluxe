using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private string gameName;

    private bool canPress;

    

    private void Update()
    {
        WhichGame();

        switch (gameName)
        {
            case "RetroShooter":
                if(canPress)
                SceneManager.LoadScene(1);
                break;
        }
    }

    private void WhichGame()
    {
        canPress = FindAnyObjectByType<Player>().didPressed;

        if(FindAnyObjectByType<RetroShooter>().retroShooter)
        {
            gameName = "RetroShooter";
        }
        else
        {
            gameName = null;
        }
    }
}

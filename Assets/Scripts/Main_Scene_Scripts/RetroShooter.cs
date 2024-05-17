using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RetroShooter : MonoBehaviour
{
    public MaxScores maxScore;

    public GameObject text, text2;

    public TextMeshPro game;

    public bool retroShooter = false, canPressE = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            canPressE = true;

            game.text = maxScore.gameName;

            text2.SetActive(true);

            text.SetActive(true);

            retroShooter = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            canPressE = false;

            text.SetActive(false);

            text2.SetActive(false);

            retroShooter = false;
        }
    }
}

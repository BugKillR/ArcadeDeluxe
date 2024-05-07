using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RetroShooter : MonoBehaviour
{
    public MaxScores maxScore;

    public GameObject text;

    public TextMeshPro game;

    public bool retroShooter = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            game.text = maxScore.gameName;

            text.SetActive(true);

            retroShooter = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            text.SetActive(false);

            retroShooter = false;
        }
    }
}

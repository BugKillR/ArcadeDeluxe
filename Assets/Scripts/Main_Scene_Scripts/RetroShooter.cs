using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetroShooter : MonoBehaviour
{
    public GameObject text;

    public bool retroShooter = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
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

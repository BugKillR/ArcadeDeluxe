using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool interactionE = false, act = false;

    public bool didPressed;

    // Update is called once per frame
    void Update()
    {
        Activation();
    } 

    private bool getE()
    {
        interactionE = FindAnyObjectByType<RetroShooter>().canPressE;
        return interactionE;
    }

    private void Activation()
    {
        getE();

        if(interactionE && Input.GetKey(KeyCode.E))
        {
            didPressed = true;
        }
        else
        {
            didPressed = false;
        }
    }
}

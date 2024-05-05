using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ElectricSound : MonoBehaviour
{
    public GameObject ateriTrigger;

    public AudioClip clip1, clip2;

    private AudioSource src;

    private void Awake()
    {
        src = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == ateriTrigger)
        {
            src.enabled = true;

            src.clip = clip1;

            src.Play();

            StartCoroutine(Sound());
        }
     }

    IEnumerator Sound()
    {
        yield return new WaitForSeconds(clip1.length - 1);

        src.clip = clip2;

        src.Play();

        yield return new WaitForSeconds(clip2.length);

        Destroy(gameObject);
    }
}

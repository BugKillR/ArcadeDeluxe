using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public ParticleSystem particle;

    public GameObject ground;

    public Light screenLight;

    private AudioSource src;

    private void Awake()
    {
        src = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject == ground)
        {
            src.enabled = true;

            src.Play();

            particle.Play();

            StartCoroutine(Light());
        }
    }

    IEnumerator Light()
    {
        yield return new WaitForSeconds(0.5f);

        screenLight.enabled = true;

        yield return new WaitForSeconds(1f);

        screenLight.enabled = false;

        yield return new WaitForSeconds(0.3f);

        screenLight.enabled = true;

        yield return new WaitForSeconds(0.3f);

        screenLight.enabled = false;

        yield return new WaitForSeconds(1.2f);

        screenLight.enabled = true;
    }
}

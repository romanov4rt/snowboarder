using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetercor : MonoBehaviour
{
    [SerializeField] float delay = 2f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] ParticleSystem slashEffect;
    [SerializeField] AudioClip crashSFX;

    bool hasCrashed = false;

    void OnCollisionEnter2D(Collision2D other)
    {
            slashEffect.Play(); 
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground"&& !hasCrashed)
        {
            hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", delay);                 
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}  

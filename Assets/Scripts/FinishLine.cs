using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delay = 2f;   
    [SerializeField] ParticleSystem finishEffect;  
    [SerializeField] ParticleSystem finishEffect1; 
    [SerializeField] ParticleSystem finishEffect2; 
    [SerializeField] ParticleSystem finishEffect3; 
    [SerializeField] ParticleSystem finishEffect4; 

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
      {
        finishEffect.Play();
        finishEffect1.Play();
        finishEffect2.Play();
        finishEffect3.Play();
        finishEffect4.Play();
        Invoke("ReloadScene", delay);
      }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

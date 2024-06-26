using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float ReloadScenetime = 1f;
    [SerializeField] ParticleSystem FinishEffect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        // Debug.Log("You finished!");
        FinishEffect.Play();
        GetComponent<AudioSource>().Play();
        Invoke("ReloadScene",ReloadScenetime);
        
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem DustTrailEffect;
   private void OnCollisionEnter2D(Collision2D other) 
   {
        if(other.gameObject.tag == "Ground")
        {
            DustTrailEffect.Play();
        } 
   }
    private void OnCollisionExit2D(Collision2D other) 
    {
         if(other.gameObject.tag == "Ground")
        {
            DustTrailEffect.Stop();
        }   
    }

}

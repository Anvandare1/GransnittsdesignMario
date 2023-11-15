using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
 private bool haspowerup=false;
   private void OnTriggerEnter2D(Collider2D other)
  {
    
   if(other.gameObject.CompareTag("powerup"))
    {

     haspowerup=true;

     Destroy(other.gameObject);

    }
  }

}

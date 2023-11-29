using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Groundcheck : MonoBehaviour
{
   [SerializeField]
    private PlayerMovement playerMovement;
    // Update is called once per frame
    
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.transform.CompareTag("Ground")) 
        {
            playerMovement.canjump=true;
        }

        
    }
    void OnTriggerExit2D(Collider2D other) 
    {
        
        if (other.transform.CompareTag("Ground"))
        {
            playerMovement.canjump=false;
        }
    }
}

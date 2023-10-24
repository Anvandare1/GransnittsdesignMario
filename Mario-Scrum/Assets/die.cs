using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour

{
    public GameObject enemy;

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.transform.CompareTag("bullet"))
        {
            Destroy(enemy);
        }    
}
}
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class Ballphysics : MonoBehaviour
{
    float theta=0;
    void Update()
    {
        float y= Mathf.Abs (Mathf.Sin(theta));
        Vector3 position= new Vector3(transform.position.x,y-0.8f,0);
        position.x += 1 * Time.deltaTime*2;
        transform.position=position;
        theta += Mathf.PI * Time.deltaTime*2;
         
         
        
    }
}

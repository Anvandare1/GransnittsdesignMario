using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy2Patrol : MonoBehaviour
{
    public GameObject point1;
    public GameObject point2;
    private Rigidbody2D rb;
    private Transform currentPoint;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = point2.transform;
    }

    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if(currentPoint == point2.transform)
        {
            rb.velocity = new Vector2(speed * Time.deltaTime, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed * Time.deltaTime, 0);
        }
       
        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == point2.transform)
        {
            currentPoint = point1.transform;
        }
        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == point1.transform)
        {
            currentPoint = point2.transform;
        }
    }
}

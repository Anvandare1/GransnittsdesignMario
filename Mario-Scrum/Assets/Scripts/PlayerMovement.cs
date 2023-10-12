using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;



public class PlayerMovement : MonoBehaviour
{
[SerializeField] Transform groundcheck;
    private Rigidbody2D rb;
    private float jump = 500;
    private float speed = 5f;

    private bool canjump;
    void Start()  // Start is called before the first frame update
    {
        rb = GetComponent<Rigidbody2D>();
        canjump = true;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && canjump == true)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
          
        }
       
      
    }
  private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.transform.CompareTag("Ground")) 
            {
                canjump=true;
            }

            
        }
        private void OnCollisionExit2D(Collision2D other) {
            if (other.transform.CompareTag("Ground")){
                canjump=false;
            }
        }
    void FixedUpdate() // Update is called once per frame
    {

        Vector3 movement = new Vector3();

        if(Input.GetKey(KeyCode.S))
        {
            
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            movement.x = -1;
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            movement.x = 1;
        }
    
        movement.Normalize();
        transform.position += movement * Time.deltaTime * speed;



    
    }

  
}

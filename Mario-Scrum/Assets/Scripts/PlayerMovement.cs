using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;



public class PlayerMovement : MonoBehaviour
{
[SerializeField] Transform groundcheck;
    private Rigidbody2D rb;
    private float jump = 500;
    private float speed = 5f;

    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireForce = 20f;

    public Powerup power;

    public bool haspowerup = false;

    public bool canjump;
    void Start()  // Start is called before the first frame update
    {
        rb = GetComponent<Rigidbody2D>();
        canjump = true;
    }
     public void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.right * fireForce, ForceMode2D.Impulse);
     }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && canjump == true)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump)); 
        }

        Vector3 cameraPos = transform.position;
        cameraPos.z = -1;
        Camera.main.transform.position = cameraPos;   

        if(Input.GetKeyDown(KeyCode.F)&& haspowerup)
        {
            Fire();
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
    private void OnCollisionEnter2D(Collision2D other) 
    {
        
        if (other.gameObject.CompareTag("Enemy head"))
        {
            Destroy(other.transform.parent.gameObject);    
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("level1"); 
        }


           
    }  

    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.CompareTag("Flower")){
            haspowerup = true;
            Destroy(other.gameObject);
        }

    }
         
}
   
  
   
  


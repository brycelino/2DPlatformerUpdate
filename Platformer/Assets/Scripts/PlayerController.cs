using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public HealthBar hb;
    public float speed = 1;
    public float jumpForce = 10;
    Animator thingAnim;
    public SpriteRenderer thingSprite;

    public Vector3 respawnPosition;
    public GameObject fallDetector;

    public Transform groundCheck;
    public LayerMask mask;
    private bool IsGrounded;
    public float groundCheckRadius;

    public int Playerjumps;
    private int tempPlayerJumps;

    public HealthBar healthBar;
    

    // Start is called before the first frame update
    void Start()
    {
        respawnPosition = transform.position;
        thingAnim = GetComponentInChildren<Animator>();
        
    }
    
    

    // Update is called once per frame
    void Update()
    {
        IsGrounded = Physics2D.Raycast(groundCheck.position, Vector2.down, groundCheckRadius, mask);
        float h = Input.GetAxis("Horizontal");

     
        thingAnim.SetFloat("speed", Mathf.Abs(h));
        
        
        thingSprite.flipX = h < 0;
        

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        Vector3 vel = new Vector3();

        vel.x = h * speed;
        vel.y = rb.velocity.y;
        vel.z = 0;

        if(IsGrounded)
        {
            tempPlayerJumps = Playerjumps;
        }
        

        if (Input.GetButtonDown("Jump") && tempPlayerJumps > 0)
        {
          
            vel.y = jumpForce;
            tempPlayerJumps--;
            
        }

        rb.velocity = vel;
        

        RaycastHit2D hit = Physics2D.Raycast(groundCheck.position, Vector2.down, groundCheckRadius, mask);
        if (hit == true)
        {
            Debug.Log(hit.transform.name);

            Debug.DrawLine(transform.position, hit.point, Color.blue);
        }

    }

    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.tag == "FallDetector" && GameManager.instance.Lives > 0)
        {
            transform.position = respawnPosition;
            GameManager.instance.Lives--;
        }
        if (GameManager.instance.Lives < 1)
        {
            SceneManager.LoadScene(2);
            GameManager.instance.score = 0;
            
        }
        



    }

}

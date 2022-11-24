using System;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMove : MonoBehaviour
{
    //public float MovementSpeed = 1;
    public float JumpForce = 1;
    private float horizontal;
    private float movement;
    private float direction;
    private Animator anim;
    

    [SerializeField] private float speed = 1;
    //[SerializeField] private float jumpPower = 1;
    public bool isFacingRight = true;
    
    
    [SerializeField] private Rigidbody2D rb;
    public Weapon weapon;
    //[SerializeField] private Transform groundCheck;
    //[SerializeField] private LayerMask groundLayer;
    
    private int score = 0;
    
    [SerializeField] private Text scoreText;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    
    private void Update()
    {
        //Jump
        if (Input.GetKey(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.001f)
            rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        
        
        // turn around
        /*if (!Mathf.Approximately(0,movement))
        {
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180,0) : Quaternion.identity;
        }*/
        
        
        //Fire
        if (Input.GetMouseButtonDown(0))
        {
            weapon.Fire();
        }
        
        //Reload
        if (Input.GetKeyDown(KeyCode.R))
        {
            weapon.Reload();
        }
    }

    private void FixedUpdate()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        /*if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }*/
        
        //set animator
        anim.SetBool("Run", horizontal != 0);
        
        Flip();
    }

    /*public void SetDirection(float _direction)
    {
        direction = _direction;
        gameObject.SetActive(true);

        float localScaleX = transform.localScale.x;
        if (Mathf.Sign(localScaleX) != _direction)
        {
            localScaleX = -localScaleX;
        }
    }*/

    //collect point
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Point"))
        {
            Destroy(collision.gameObject);
            score++;
            Debug.Log("Score : " + score);
            scoreText.text = "Score : " + score;
        }
    }

    /*private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }*/
        
    private void Flip()
    {
        if (isFacingRight && horizontal <0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
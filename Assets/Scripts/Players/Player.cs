using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{

    [SerializeField]
    private LayerMask platformsLayerMask;
    Rigidbody2D rb;
    float horizontal;
    public float speed;
    //Jumping with double jump
    bool jump = true;
    public float jumpVelocity = 10f;
    private BoxCollider2D BoxCollider2d;
    public bool isGrounded;
    public bool canDoubleJump;
    public float jumpHeight;
    // face direction
    bool faceright = true;
    Vector3 scale;

    public bool canMove;
    public Animator whiteAnim;


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        BoxCollider2d = transform.GetComponent<BoxCollider2D>();
        whiteAnim = GetComponent<Animator>();
        canMove = true;
    }
    public Vector3 GetPosition()
    {
        return transform.position;
    }
    private void Update()
    {
        Jump();
        
    }
    
    void FixedUpdate()
    {
        if (canMove)
        {
            horizontal = CrossPlatformInputManager.GetAxisRaw("Horizontal");
            rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
            whiteAnim.SetFloat("speed", Mathf.Abs(horizontal));
            if (horizontal > 0 && faceright == false)
            {
                FaceDirection();
            }
            if (horizontal < 0 && faceright == true)
            {
                FaceDirection();
            }
        }
        

    }
    void FaceDirection()
    {
        scale = gameObject.transform.localScale;
        scale.x *= -1;
        gameObject.transform.localScale = scale;
        faceright = !faceright;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        whiteAnim.SetBool("IsJumping", false);
        if (collision.gameObject.tag == "Ground")
        {
            jump = true;
            isGrounded = true;
        }
    }
    void OnCollisionStay2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }

    void Jump()
    {
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            
            if (isGrounded)
            {
                rb.velocity = Vector2.up * jumpHeight;
                canDoubleJump = true;
                
            }
            else if (canDoubleJump)
            {
                jumpHeight = jumpHeight / 1.5f;
                rb.velocity = Vector2.up * jumpHeight;
                canDoubleJump = false;
                jumpHeight *= 1.5f;
            }
        }
    }
    


}

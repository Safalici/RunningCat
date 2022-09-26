using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class Player_2 : MonoBehaviour
{
    [SerializeField]
    private LayerMask platformsLayerMask;
    
    Rigidbody2D rb;
    float horizontal;
    public float speed;

    public bool canMove;
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


    //android movement control
    private bool moveRight;
    private bool moveLeft;

    public Animator whiteAnim;
    //Handle camera shake
    // public float camShakeAmt = 0.1f;
    //CameraShake2 camShake;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        BoxCollider2d = transform.GetComponent<BoxCollider2D>();
        //camShake = GameMaster.gm.GetComponent<CameraShake2>();
        moveRight = false;
        moveLeft = false;
        canMove = true;
    }
    public void pointerDownLeft()
    {
        moveLeft  = true;
    }
    public void pointerUpLeft()
    {
        moveLeft = false;
    }
    public void pointerDownRight()
    {
        moveRight = true;
    }
    public void pointerUpRight()
    {
        moveRight = false;
    }
    public Vector3 GetPosition()
    {
        return transform.position;
    }
    private void Update()
    {
        Jump();
        Movement();
    }
    void Movement()
    {
        if (canMove)
        {
            if (moveLeft)
            {
                horizontal = -speed;
            }
            else if (moveRight)
            {
                horizontal = speed;
            }
            else
            {
                horizontal = 0;
            }
        }
        
    }
    void FixedUpdate()
    {
        if (canMove)
        {
            rb.velocity = new Vector2(horizontal, rb.velocity.y);
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
            //camShake.Shake(camShakeAmt, 0.2f);

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

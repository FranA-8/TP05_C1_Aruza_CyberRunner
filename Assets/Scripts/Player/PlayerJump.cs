using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private PlayerDataSo data;
    [SerializeField] private GameObject player;
    public float jumpForce;
    private Rigidbody2D rb;
    bool canJump = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        jumpForce = data.jumpForce;
    }
    public void PowerUpJumpForce(float value)
    {
        jumpForce += value;
        if (jumpForce >= 25)
        {
            jumpForce = 25;
        }
    }

    public float GetJumpForce()
    {
        return jumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            canJump = true;
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            canJump = false;
        }
    }
    private void Update()
    { 
          if (canJump == true && (Input.GetKeyDown(KeyCode.Space)))
          {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

            canJump = false;

            animator.SetTrigger("Jumped");
          }

    }   
}

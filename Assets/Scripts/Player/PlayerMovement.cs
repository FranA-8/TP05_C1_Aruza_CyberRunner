using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerDataSo data;
    [SerializeField] private GameObject player;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float maxSpeed;
    private Rigidbody2D rb;
    private void Start()
    {
        moveSpeed = data.moveSpeed;
    }
    public void PowerUpMoveSpeed(float value)
    {
        moveSpeed += value;
        if (moveSpeed >= 800)
        {
            moveSpeed = 800;
        }
    }

    public float GetMoveSpeed()
    {
        return moveSpeed;
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(moveSpeed * Time.fixedDeltaTime, 0f));
        rb.linearVelocity = Vector2.ClampMagnitude(rb.linearVelocity, maxSpeed);
    }
}

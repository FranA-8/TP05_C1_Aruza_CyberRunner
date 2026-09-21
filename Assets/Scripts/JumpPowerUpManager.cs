using UnityEngine;

public class JumpPowerUpManager : MonoBehaviour
{
    [SerializeField] private PlayerJump player;
    [SerializeField] private float powerUpJump;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.jumpForce += powerUpJump;

        }
    }
}

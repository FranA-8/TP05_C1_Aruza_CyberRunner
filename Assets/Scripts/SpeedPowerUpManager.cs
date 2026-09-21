using UnityEngine;

public class SpeedPowerUpManager : MonoBehaviour
{
    [SerializeField] private PlayerMovement player;
    [SerializeField] private float powerUpSpeed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.moveSpeed += powerUpSpeed;

        }
    }
}

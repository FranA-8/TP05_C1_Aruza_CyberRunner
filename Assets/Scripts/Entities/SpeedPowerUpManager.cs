using UnityEngine;

public class SpeedPowerUpManager : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject powerUpPrefab;
    [SerializeField] private PlayerMovement player;
    [SerializeField] private float powerUpSpeed;
    private bool collected = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.PowerUpMoveSpeed(powerUpSpeed);

            collected = true;

            animator.SetTrigger("Collected");

            if (collected == true)
            {
                Destroy(powerUpPrefab, 1f);
            }
        }
    }
}

using UnityEngine;

public class JumpPowerUpManager : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject powerUpPrefab;
    [SerializeField] private PlayerJump player;
    [SerializeField] private float powerUpJump;
    private bool collected = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            player.PowerUpJumpForce(powerUpJump);

            collected = true;

            animator.SetTrigger("Collected");

            if (collected == true)
            {
                Destroy(powerUpPrefab, 1f);
            }
        }
    }
}

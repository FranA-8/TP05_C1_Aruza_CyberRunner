using UnityEngine;

public class ObstaclesGenerator : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private float spawnTimer = 3;
    [SerializeField] private float despawnTimer = 2;
    [SerializeField] private float obstaclePositionY = -3;
    private float playerPositionX = -6.65f;
    private float playerPositionY = -2.55f;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnTimer)
        {
            float playerPositionX = player.transform.position.x + 15f;

            GameObject i = Instantiate(obstaclePrefab, new Vector3(playerPositionX, obstaclePositionY, 0), transform.rotation);
            Destroy(i, despawnTimer);
            
            timer = 0;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.transform.position = new Vector2(playerPositionX, playerPositionY);
        }
    }
}

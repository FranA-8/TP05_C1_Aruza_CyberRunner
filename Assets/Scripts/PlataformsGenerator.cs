using UnityEngine;

public class PlataformsGenerator : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject plataformPrefab;
    [SerializeField] private float spawnTimer = 3;
    [SerializeField] private float despawnTimer = 2;
    [SerializeField] private float plataformPositionY = -1;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnTimer)
        {
            float playerPositionX = player.transform.position.x + 20f;

            GameObject i = Instantiate(plataformPrefab, new Vector3(playerPositionX, plataformPositionY, 0), transform.rotation);
            Destroy(i, despawnTimer);

            timer = 0;
        }

    }
}

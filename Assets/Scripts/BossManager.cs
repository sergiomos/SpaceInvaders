using UnityEngine;

public class BossManager : MonoBehaviour
{
    public GameObject bossShipPrefab;
    public float minSpawnTime = 30f;
    public float maxSpawnTime = 50f;

    private float spawnTimer;

    void Start()
    {
        spawnTimer = Random.Range(minSpawnTime, maxSpawnTime);
    }

    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            SpawnBoss();
            spawnTimer = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }

    void SpawnBoss()
    {
        // Apenas o GameManager define onde a nave é criada
        Instantiate(bossShipPrefab, new Vector3(-27f, 3.3f, 0f), Quaternion.identity);
    }
}
using UnityEngine;

public class RepeatingSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefabToSpawn;
    [SerializeField] private float spawnInterval = 2f;
    [SerializeField] private Transform spawnPoint;

    private float timer;

    void Start()
    {
        Spawn();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            timer = 0f;
            Spawn();
        }
    }

    void Spawn()
    {
        Vector3 position = spawnPoint != null ? spawnPoint.position : transform.position;
        Quaternion rotation = spawnPoint != null ? spawnPoint.rotation : transform.rotation;

        Instantiate(prefabToSpawn, position, rotation);
    }
}
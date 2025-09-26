using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Array of animal prefabs to spawn
    public GameObject[] animalPrefabs;

    // Spawn position range
    private float spawnRangeX = 20;

    // Fixed spawn position on Z axis
    private float spawnPositionZ = 20;

    // Delay before the first spawn
    private float spawnStartDelay = 2;

    // Interval between spawns
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), spawnStartDelay, spawnInterval);
    }

    private void SpawnRandomAnimal()
    {
        // Randomly generate animal index and spawn position
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);

        // Randomly select an animal prefab to spawn
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // Spawn the selected animal prefab at the spawn position
        Instantiate(animalPrefabs[animalIndex], spawnPosition,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
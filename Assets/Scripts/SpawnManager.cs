using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Array of animal prefabs to spawn
    public GameObject[] animalPrefabs;

    // Spawn position range
    private float spawnRangeX = 20;

    // Fixed spawn position on Z axis
    private float spawnPositionZ = 20;

    // Update is called once per frame
    void Update()
    {
        // Check if the "S" key is pressed
        if (Input.GetKeyDown(KeyCode.S))
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
}
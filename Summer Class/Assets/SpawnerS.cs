using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject entityToSpawn;
    public SpawnManagerScriptableObject spawnManagerValues;
    private int instanceNumber = 1;
    void Start()
    {
        SpawnEntities();
    }

    // Update is called once per frame
    void SpawnEntities()
    {
        int currentSpawnpointIndex = 0;

        for (int i = 0; i < spawnManagerValues.numberOfPrefabsToCreate; i++)
        {
            GameObject currentEntity = Instantiate(entityToSpawn,
                spawnManagerValues.spawnPoints[currentSpawnpointIndex], Quaternion.identity);

            currentEntity.name = spawnManagerValues.prefabName + instanceNumber;

            currentSpawnpointIndex = (currentSpawnpointIndex + 1) % spawnManagerValues.spawnPoints.Length;

            instanceNumber++;
        }
    }
}

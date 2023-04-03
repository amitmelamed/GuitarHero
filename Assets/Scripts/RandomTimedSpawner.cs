using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

using UnityEngine;

public class RandomTimedSpawner : MonoBehaviour
{
    [SerializeField] Mover prefabOneToSpawn;
    [SerializeField] Mover prefabTwoToSpawn;
    [SerializeField] Mover prefabThreeToSpawn;
    private Mover prefabToSpawn;
    private int lastNumber;


    [SerializeField] Vector3 velocityOfSpawnedObject;
    [Tooltip("Minimum time between consecutive spawns, in seconds")][SerializeField] float minTimeBetweenSpawns = 1f;
    [Tooltip("Maximum time between consecutive spawns, in seconds")][SerializeField] float maxTimeBetweenSpawns = 3f;
    [Tooltip("Maximum distance in X between spawner and spawned objects, in meters")][SerializeField] float maxXDistance = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        prefabToSpawn = prefabOneToSpawn;
        this.StartCoroutine(SpawnRoutine());    // co-routines
    }

    int GetRandom(int min, int max)
    {
        int rand = Random.Range(min, max);
        while (rand == lastNumber)
            rand = Random.Range(min, max);
        lastNumber = rand;
        return rand;
    }

    IEnumerator SpawnRoutine()
    {    // co-routines
         // async Task SpawnRoutine() {  // async-await
        while (true)
        {

            int rand = GetRandom(0, 3);
            if (rand == 0)
            {
                prefabToSpawn = prefabOneToSpawn;
            }
            else if (rand == 1)
            {
                prefabToSpawn = prefabTwoToSpawn;
            }
            else if(rand == 2)
            {
                prefabToSpawn = prefabThreeToSpawn;
            }
            

            float timeBetweenSpawnsInSeconds = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            yield return new WaitForSeconds(timeBetweenSpawnsInSeconds);       // co-routines
            // await Task.Delay((int)(timeBetweenSpawnsInSeconds*1000));       // async-await
            Vector3 positionOfSpawnedObject = new Vector3(
                transform.position.x + Random.Range(-maxXDistance, +maxXDistance),
                transform.position.y,
                transform.position.z);
            GameObject newObject = Instantiate(prefabToSpawn.gameObject, positionOfSpawnedObject, Quaternion.identity);
            newObject.GetComponent<Mover>().SetVelocity(velocityOfSpawnedObject);
        }
    }
}

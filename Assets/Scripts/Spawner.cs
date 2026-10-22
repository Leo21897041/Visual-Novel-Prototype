using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstaclePrefab;

    public void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
    }
}

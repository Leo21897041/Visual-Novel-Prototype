using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float moveSpeed;
    public Spawner spawner;

    private void Start()
    {
        spawner = FindFirstObjectByType<Spawner>();

        moveSpeed = Random.Range(8f, 20f);
    }

    void Update()
    {
        transform.position += moveSpeed * Time.deltaTime * Vector3.left;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            spawner.SpawnObstacle();
        }
    }
}

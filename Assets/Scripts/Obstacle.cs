using TMPro;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float moveSpeed;
    public Spawner spawner;
    public Player player;

    private void Start()
    {
        spawner = FindFirstObjectByType<Spawner>();
        player = FindFirstObjectByType<Player>();

        moveSpeed = Random.Range(8f, 25f);
    }

    void Update()
    {
        transform.position += moveSpeed * Time.deltaTime * Vector3.left;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.IncreaseSupply();
            spawner.SpawnObstacle();
        }
    }

}

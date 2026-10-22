using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpForce;

    public bool isGrounded;

    public Spawner spawner;

    [Header("Canvas UI")]
    public TextMeshProUGUI startText;
    public GameObject endingPanel;

    private void Start()
    {
        spawner = FindFirstObjectByType<Spawner>();
        rb = GetComponent<Rigidbody2D>();
        endingPanel.SetActive(false);
    }
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && isGrounded == true)
        {
            rb.linearVelocity = new Vector2(0, jumpForce);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            GetComponent<CircleCollider2D>().enabled = false;
            endingPanel.SetActive(true);
        }
    }

    public void StartButton()
    {
        startText.enabled = false;

        spawner.SpawnObstacle();
    }
}

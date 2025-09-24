using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public GameObject shotPrefab;
    public float shotSpeed = 10f;
    public float horizontalBoundary = 8.5f; // Limite horizontal da tela

    private Rigidbody2D rb;
    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontalInput, 0);
        rb.velocity = movement * speed;

        // Adiciona um limite à posição X da nave
        float clampedX = Mathf.Clamp(transform.position.x, -horizontalBoundary, horizontalBoundary);
        transform.position = new Vector2(clampedX, transform.position.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }

        GameObject shot = Instantiate(shotPrefab, transform.position, Quaternion.identity);
        Rigidbody2D shotRb = shot.GetComponent<Rigidbody2D>();
        if (shotRb != null)
        {
            shotRb.velocity = new Vector2(0, shotSpeed);
        }
    }
}
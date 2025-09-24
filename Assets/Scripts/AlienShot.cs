using UnityEngine;

public class AlienShot : MonoBehaviour
{
    public float shotSpeed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Faz o tiro se mover para baixo
        rb.velocity = new Vector2(0, -shotSpeed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Se o tiro colidir com o Player
        if (other.CompareTag("Player"))
        {
            GameManager.instance.LoseLife();

            Destroy(this.gameObject);
        }

        // Se o tiro colidir com a parede inferior
        if (other.CompareTag("BottomWall"))
        {
            Destroy(this.gameObject);
        }
    }
}
using UnityEngine;

public class BossShip : MonoBehaviour
{
    public float speed = 5.0f;

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(speed, 0f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Se a nave chefe colidir com a parede direita, ela desaparece
        if (other.CompareTag("SideWall"))
        {
            DespawnBoss();
        }
    }

    void DespawnBoss()
    {
        Destroy(gameObject);
    }
}
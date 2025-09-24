using UnityEngine;

public class AlienManager : MonoBehaviour
{
    public float speed = 2.0f;
    public float descentAmount = 0.5f;
    public float waitTime = 1.0f;
    public int stepsBeforeDescent = 10;

    // Variáveis para o tiro
    public GameObject alienShotPrefab;
    public float raycastDistance = 10f;

    private Rigidbody2D rb2d;
    private float timer;
    private int currentSteps = 0;
    private int direction = 1;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(direction * speed, 0);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= waitTime)
        {
            ChangeState();
            timer = 0.0f;
        }
    }

    void ChangeState()
    {
        Vector2 vel = rb2d.velocity;
        vel.y = 0;

        direction *= -1;
        vel.x = direction * speed;

        currentSteps++;

        if (currentSteps >= stepsBeforeDescent)
        {
            vel.y = -descentAmount;
            currentSteps = 0;
        }

        rb2d.velocity = vel;
    }

    public void FireShot()
    {
        Instantiate(alienShotPrefab, transform.position, Quaternion.identity);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("BottomWall"))
        {
            GameManager.instance.GameOver();
        }
    }
}
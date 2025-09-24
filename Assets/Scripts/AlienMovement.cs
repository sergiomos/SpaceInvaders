using UnityEngine;

public class AlienMovement : MonoBehaviour
{
    public float speed = 2.0f;
    public float descentAmount = 0.5f;
    public float waitTime = 1.0f;
    public int stepsBeforeDescent = 10;

    // Variáveis para o tiro
    public GameObject alienShotPrefab;
    public float minShotTime = 2f;
    public float maxShotTime = 5f;
    private float shotTimer;

    private Rigidbody2D rb2d;
    private float timer;
    private int currentSteps = 0;
    private int direction = 1;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(direction * speed, 0);
        // Define o tempo do primeiro tiro aleatoriamente
        shotTimer = Random.Range(minShotTime, maxShotTime);
    }

    void Update()
    {
        timer += Time.deltaTime;
        shotTimer -= Time.deltaTime;

        // Lógica de movimento
        if (timer >= waitTime)
        {
            ChangeState();
            timer = 0.0f;
        }

        // Lógica de tiro
        if (shotTimer <= 0)
        {
            Shoot();
            // Reseta o temporizador de tiro para um novo valor aleatório
            shotTimer = Random.Range(minShotTime, maxShotTime);
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

    void Shoot()
    {
        // Cria uma nova instância do tiro do alien na posição dele
        Instantiate(alienShotPrefab, transform.position, Quaternion.identity);
    }
}
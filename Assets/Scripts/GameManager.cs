using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int lives = 3;
    public Text livesText;
    public float alienShotDelay = 2.0f; // Tempo de espera entre os tiros

    // A variável que você estava procurando
    public GameObject alienShotPrefab;

    private float alienShotTimer;
    public int totalAliens;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        totalAliens = FindObjectsOfType<AlienManager>().Length;
        UpdateLivesDisplay();
        alienShotTimer = alienShotDelay;
    }

    void Update()
    {
        alienShotTimer -= Time.deltaTime;
        if (alienShotTimer <= 0)
        {
            ShootOneAlien();
            alienShotTimer = alienShotDelay;
        }
    }

    public void LoseLife()
    {
        lives--;
        UpdateLivesDisplay();

        if (lives <= 0)
        {
            GameOver();
        }
    }

    public void CheckWinCondition()
    {
        totalAliens--;
        if (totalAliens <= 0)
        {
            // Pega o índice da cena atual
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

            // Se a fase atual for a Fase 1 (índice 1)
            if (currentSceneIndex == 1)
            {
                // Carrega a próxima cena (a Fase 2, que tem o índice 2)
                SceneManager.LoadScene(currentSceneIndex + 1);
            }
            // Se for a última fase (a Fase 2, que tem o índice 2)
            else if (currentSceneIndex == 2)
            {
                // Carrega a tela de vitória
                WinGame();
            }
        }
    }

    public void WinGame()
    {
        Debug.Log("Você Venceu!");
        SceneManager.LoadScene("Scenes/Vitoria");
    }

    public void GameOver()
    {
        Debug.Log("Game Over!");
        // Carrega a cena de derrota que você acabou de criar
        SceneManager.LoadScene("Derrota");
    }

    void UpdateLivesDisplay()
    {
        if (livesText != null)
        {
            livesText.text = "Vidas: " + lives;
        }
    }

    void ShootOneAlien()
    {
        AlienManager[] allAliens = FindObjectsOfType<AlienManager>();

        System.Collections.Generic.List<AlienManager> frontRowAliens = new System.Collections.Generic.List<AlienManager>();

        foreach (AlienManager alien in allAliens)
        {
            if (IsFrontRowAlien(alien))
            {
                frontRowAliens.Add(alien);
            }
        }

        if (frontRowAliens.Count > 0)
        {
            int randomIndex = Random.Range(0, frontRowAliens.Count);
            frontRowAliens[randomIndex].FireShot();
        }
    }

    bool IsFrontRowAlien(AlienManager alien)
    {
        RaycastHit2D hit = Physics2D.Raycast(alien.transform.position, Vector2.down, alien.raycastDistance, LayerMask.GetMask("Alien"));
        return hit.collider == null;
    }
}
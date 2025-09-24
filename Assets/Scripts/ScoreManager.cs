using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // A instância estática do nosso gerenciador de pontuação
    public static ScoreManager instance;

    // A variável que vai guardar o nosso objeto de texto
    public Text scoreText;

    // Variável para a pontuação atual
    private int score = 0;

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
        UpdateScoreDisplay();
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreDisplay();
    }

    void UpdateScoreDisplay()
    {
        // Esta linha só funciona se o 'scoreText' estiver ligado no Inspector
        if (scoreText != null)
        {
            scoreText.text = "Pontuação: " + score;
        }
    }
}
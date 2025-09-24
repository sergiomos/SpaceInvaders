using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // A inst�ncia est�tica do nosso gerenciador de pontua��o
    public static ScoreManager instance;

    // A vari�vel que vai guardar o nosso objeto de texto
    public Text scoreText;

    // Vari�vel para a pontua��o atual
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
        // Esta linha s� funciona se o 'scoreText' estiver ligado no Inspector
        if (scoreText != null)
        {
            scoreText.text = "Pontua��o: " + score;
        }
    }
}
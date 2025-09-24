using UnityEngine;

public class Shot : MonoBehaviour
{
    // A função OnTriggerEnter2D é chamada quando o tiro detecta uma colisão
    void OnTriggerEnter2D(Collider2D other)
    {
        // Se o objeto colidido for um alienígena...
        if (other.CompareTag("Alien_1") || other.CompareTag("Alien_2") || other.CompareTag("Alien_3") || other.CompareTag("BossAlien"))
        {
            // Adiciona a pontuação
            if (ScoreManager.instance != null)
            {
                // Verifica a pontuação do alien e a adiciona
                if (other.CompareTag("Alien_1")) ScoreManager.instance.AddScore(10);
                else if (other.CompareTag("Alien_2")) ScoreManager.instance.AddScore(20);
                else if (other.CompareTag("Alien_3")) ScoreManager.instance.AddScore(30);
                else if (other.CompareTag("BossAlien")) ScoreManager.instance.AddScore(50);
            }

            // Avisa o GameManager que um alienígena foi destruído
            if (GameManager.instance != null)
            {
                GameManager.instance.CheckWinCondition();
            }

            // Destrói o alienígena
            Destroy(other.gameObject);

            // Destrói o próprio tiro
            Destroy(gameObject);
        }

        // Se o tiro colidir com uma parede
        if (other.CompareTag("TopWall") || other.CompareTag("SideWall"))
        {
            // Destrói o tiro
            Destroy(gameObject);
        }
    }
}
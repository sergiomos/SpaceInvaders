using UnityEngine;

public class Shot : MonoBehaviour
{
    // A fun��o OnTriggerEnter2D � chamada quando o tiro detecta uma colis�o
    void OnTriggerEnter2D(Collider2D other)
    {
        // Se o objeto colidido for um alien�gena...
        if (other.CompareTag("Alien_1") || other.CompareTag("Alien_2") || other.CompareTag("Alien_3") || other.CompareTag("BossAlien"))
        {
            // Adiciona a pontua��o
            if (ScoreManager.instance != null)
            {
                // Verifica a pontua��o do alien e a adiciona
                if (other.CompareTag("Alien_1")) ScoreManager.instance.AddScore(10);
                else if (other.CompareTag("Alien_2")) ScoreManager.instance.AddScore(20);
                else if (other.CompareTag("Alien_3")) ScoreManager.instance.AddScore(30);
                else if (other.CompareTag("BossAlien")) ScoreManager.instance.AddScore(50);
            }

            // Avisa o GameManager que um alien�gena foi destru�do
            if (GameManager.instance != null)
            {
                GameManager.instance.CheckWinCondition();
            }

            // Destr�i o alien�gena
            Destroy(other.gameObject);

            // Destr�i o pr�prio tiro
            Destroy(gameObject);
        }

        // Se o tiro colidir com uma parede
        if (other.CompareTag("TopWall") || other.CompareTag("SideWall"))
        {
            // Destr�i o tiro
            Destroy(gameObject);
        }
    }
}
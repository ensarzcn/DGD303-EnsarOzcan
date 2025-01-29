using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timeLimit = 65f; // 65 saniyelik zamanlayıcı
    private float timeRemaining;
    private bool isGameWon = false; // Kazanma durumu
    public GameObject winPanel; // Kazandınız paneli

    private void Start()
    {
        timeRemaining = timeLimit;
        winPanel.SetActive(false); // Başlangıçta Kazanma paneli gizlensin
    }

    private void Update()
    {
        // Eğer oyun kazanılmamışsa ve timer 0'ı geçmemişse
        if (!isGameWon)
        {
            timeRemaining -= Time.deltaTime; // Zamanı azalt

            if (timeRemaining <= 0)
            {
                ShowWinScreen();
            }
        }
    }

    // Kazanma ekranını göster
    void ShowWinScreen()
    {
        isGameWon = true;
        winPanel.SetActive(true); // Kazanma panelini göster
    }

    // Sahne yenilenirse zamanı sıfırla
    public void ResetTimer()
    {
        timeRemaining = timeLimit; // Zamanı sıfırla
    }

    // Kazanma panelindeki butona tıklandığında sahneyi yenile
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}


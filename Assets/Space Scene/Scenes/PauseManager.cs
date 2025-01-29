  using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1f; // Önce zamanı normale döndür
            SceneManager.LoadScene(0); // Ana menüye dön (Sahne 0)
        }
    }
}

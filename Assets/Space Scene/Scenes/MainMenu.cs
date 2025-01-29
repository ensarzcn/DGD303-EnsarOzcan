using UnityEngine;
using UnityEngine.SceneManagement;  // Sahne yönetimi için gerekli

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1); 
    }
}


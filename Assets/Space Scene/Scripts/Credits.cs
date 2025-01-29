using UnityEngine;

public class Credits : MonoBehaviour
{
    public GameObject creditsPanel; // Paneli bağlamak için değişken

    public void ShowCredits()
    {
        creditsPanel.SetActive(true); // Paneli aç
    }

    public void HideCredits()
    {
        creditsPanel.SetActive(false); // Paneli kapat
    }
}

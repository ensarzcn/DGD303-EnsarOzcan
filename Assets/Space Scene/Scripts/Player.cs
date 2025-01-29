using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Sahne yönetimi için

public class Player : MonoBehaviour
{
    public GameObject destructionFX;

    public static Player instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void GetDamage(int damage)
    {
        Destruction();
    }

    void Destruction()
    {
        // Efekti hemen çalıştır
        Instantiate(destructionFX, transform.position, Quaternion.identity);
        
        // Görsel bileşeni gizle (mesela MeshRenderer)
        Renderer playerRenderer = GetComponent<Renderer>();
        if (playerRenderer != null)
        {
            playerRenderer.enabled = false;  // Görseli gizle
        }

        // 2 saniye sonra oyuncuyu yok et ve sahneyi yeniden başlat
        Invoke("DestroyPlayerAndRestart", 2f);
    }

    void DestroyPlayerAndRestart()
    {
        // Oyuncuyu yok et
        Destroy(gameObject);
        
        // Sahneyi yeniden başlat
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}









using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            // SceneManager : Çalýþma zamanýnda sahne yönetimi yapar.
            // SceneManager.LoadScene : Sahneyi yapý ayarlarýnda adýna veya dizine göre yükler.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }
    }
}

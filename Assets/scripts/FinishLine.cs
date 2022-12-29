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
            // SceneManager : �al��ma zaman�nda sahne y�netimi yapar.
            // SceneManager.LoadScene : Sahneyi yap� ayarlar�nda ad�na veya dizine g�re y�kler.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }
    }
}

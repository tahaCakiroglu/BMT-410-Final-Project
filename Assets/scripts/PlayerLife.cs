using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public string TAG_ENEMY = "enemyBody";
    public string TAG_TRAPGROUND = "trapGround";
    public string OBJ_SPORTSCAR = "SportsCar";
    public float DROPLIMIT = 100f;
    private int soundCount = 0;
    private float INITIAL_X = 0.18f;
    private float INITIAL_Y = 0.23f;
    private float INITIAL_Z = -11.40f;
    [SerializeField] AudioSource deathSound;
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag(TAG_ENEMY) | collision.gameObject.CompareTag(TAG_TRAPGROUND))
        {
            // bool Rigidbody.isKinematic : Fizi�in kat� g�vdeyi etkileyip etkilemedi�ini kontrol eder.
            GameObject.Find(OBJ_SPORTSCAR).transform.position =  new Vector3( INITIAL_X, INITIAL_Y, INITIAL_Z );
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerMovement>().enabled = false;
            PlayerDead();
        }
    }

    // PlayerDead fonksiyonu ile ki�i �l�nce sound efekti gelir ve leveli reloadlar.
    private void PlayerDead()
    {
        if (!deathSound.isPlaying && soundCount == 0) { 
            deathSound.Play();
            soundCount++;
        }
        // Invoke : Kendi timer'i s�f�rlar ve leveli reloadlar.
        Invoke(nameof(ReloadLevel), 1f);
    }

    private void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Sahne ad�n� dinamik olarak de�i�tiriyoruz.
    }

    private void Update()
    {
        if (transform.position.y < -DROPLIMIT*3)
        {
            PlayerDead();
        }
    }
}

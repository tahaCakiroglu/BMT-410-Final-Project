using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb; 
    [SerializeField]float UNIT_SPEED = 5f;
    [SerializeField]AudioSource jumpSound;
    public string TAG_ENEMYHEAD = "enemyHead"; 
    public string TAG_GROUND = "ground"; 
    private string INPUT_HORIZONTAL = "Horizontal";
    private string INPUT_VERTICAL = "Vertical";
    private string INPUT_JUMP = "Jump";
    private bool isGrounded = false;

    void MoveCharcter() { 

        // UnityEngine.input : Giriþ Arayüzü
        float horizontalInput = Input.GetAxis(INPUT_HORIZONTAL);
        float verticalInput = Input.GetAxis(INPUT_VERTICAL);

        rb.velocity = new Vector3(horizontalInput * UNIT_SPEED, rb.velocity.y, verticalInput * UNIT_SPEED);

        if (Input.GetButtonDown(INPUT_JUMP) && isGrounded)
        {
            Jump();
        }
    }

    //Jump Fonksiyonu
    void Jump() 
    {
        rb.velocity = new Vector3(rb.velocity.x, UNIT_SPEED, rb.velocity.z);
        jumpSound.Play();
        isGrounded = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Düþman collision
        if (collision.gameObject.CompareTag(TAG_ENEMYHEAD))
        {
            Destroy(collision.transform.parent.gameObject);
            Jump();
        }

        // Yer prefab collision
        if (collision.gameObject.CompareTag(TAG_GROUND))
        {
            isGrounded = true;
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        UnityEngine.Debug.Log("Baþlangýç Pozisyonunu Kontrol Et");
        UnityEngine.Debug.Log(transform.position); // Baþlangýç pozisyon kontrol et.
    }

    void Update()
    {
        MoveCharcter();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float speedX;
    [SerializeField] float speedY;
    [SerializeField] float speedZ;

    //Rotate fonksiyonu ile x,y,z ye g�re konumu ayarlan�r. (COIN'in 360 derece d�nd�r�lmesinde kullan�yoruz.)
    void Update()
    {
        transform.Rotate(360*speedX*Time.deltaTime, 360*speedY*Time.deltaTime, 360*speedZ*Time.deltaTime);
    }
}

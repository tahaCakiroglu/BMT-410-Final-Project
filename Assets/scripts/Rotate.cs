using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float speedX;
    [SerializeField] float speedY;
    [SerializeField] float speedZ;

    //Rotate fonksiyonu ile x,y,z ye göre konumu ayarlanýr. (COIN'in 360 derece döndürülmesinde kullanýyoruz.)
    void Update()
    {
        transform.Rotate(360*speedX*Time.deltaTime, 360*speedY*Time.deltaTime, 360*speedZ*Time.deltaTime);
    }
}

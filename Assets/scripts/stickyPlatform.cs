using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickyPlatform : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "SportsCar")
        {
            // Transform bu komut dosyas� uyguland��� transform bile�eneni ifade eder. Tagland���nda spor araba se�ilmi�tir.
            collision.gameObject.transform.SetParent(transform);
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "SportsCar")
        {
            // E�er ��karmak isterse burdan setini bo�a �ekiyoruz.
            collision.gameObject.transform.SetParent(null);
        }
    }
}

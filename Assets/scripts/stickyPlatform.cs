using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickyPlatform : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "SportsCar")
        {
            // Transform bu komut dosyasý uygulandýðý transform bileþeneni ifade eder. Taglandýðýnda spor araba seçilmiþtir.
            collision.gameObject.transform.SetParent(transform);
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "SportsCar")
        {
            // Eðer çýkarmak isterse burdan setini boþa çekiyoruz.
            collision.gameObject.transform.SetParent(null);
        }
    }
}

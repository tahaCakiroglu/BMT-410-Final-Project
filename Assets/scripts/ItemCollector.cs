using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // import TextMeshPro

public class ItemCollector : MonoBehaviour
{
    int coins = 0; 
    [SerializeField] string TAG_COIN = "coin";
    [SerializeField] TextMeshProUGUI COIN_TEXTMESH;
    [SerializeField] AudioSource collectionSound;

    // OnTrigger ile coine tag ald���nda �al���r.
    private void OnTriggerEnter(Collider coin)
    {
        // GameObject.CompareTag : Tag nesnesinin �al��t���n� kontrol ediyor
        if (coin.gameObject.CompareTag(TAG_COIN)) {

            coins++;
            // Component : Temel obje s�n�f�
            // Componet.gameObject : Eklenen oyun nesnesi
            // Coin ald���nda nesneyle ili�kilendirip coini siler ve coin puan�n� artt�r�r.
            Destroy(coin.gameObject);
            collectionSound.Play();
            COIN_TEXTMESH.text = "Para : " + coins;
        }
    }
}

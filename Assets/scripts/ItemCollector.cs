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

    // OnTrigger ile coine tag aldýðýnda çalýþýr.
    private void OnTriggerEnter(Collider coin)
    {
        // GameObject.CompareTag : Tag nesnesinin çalýþtýðýný kontrol ediyor
        if (coin.gameObject.CompareTag(TAG_COIN)) {

            coins++;
            // Component : Temel obje sýnýfý
            // Componet.gameObject : Eklenen oyun nesnesi
            // Coin aldýðýnda nesneyle iliþkilendirip coini siler ve coin puanýný arttýrýr.
            Destroy(coin.gameObject);
            collectionSound.Play();
            COIN_TEXTMESH.text = "Para : " + coins;
        }
    }
}

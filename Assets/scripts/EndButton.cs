using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndButton : MonoBehaviour
{
    public void EndGame()
    {
        UnityEngine.Debug.Log("Game ended");
        // Unity oynatmay� durdurmaz, uygulama run process edildi�inde �al���r.
        Application.Quit();
    }
}

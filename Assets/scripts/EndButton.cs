using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndButton : MonoBehaviour
{
    public void EndGame()
    {
        UnityEngine.Debug.Log("Game ended");
        // Unity oynatmayý durdurmaz, uygulama run process edildiðinde çalýþýr.
        Application.Quit();
    }
}

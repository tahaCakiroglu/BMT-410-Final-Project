using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyperlink : MonoBehaviour
{
    public void OpenUrl(string url)
    {
        // UnityEngine.Application : Uygulama çalýþtýðýnda veri eriþimi.
        Application.OpenURL(url);
    }
}

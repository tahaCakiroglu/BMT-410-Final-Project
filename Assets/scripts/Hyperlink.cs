using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyperlink : MonoBehaviour
{
    public void OpenUrl(string url)
    {
        // UnityEngine.Application : Uygulama �al��t���nda veri eri�imi.
        Application.OpenURL(url);
    }
}

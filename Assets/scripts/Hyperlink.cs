using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyperlink : MonoBehaviour
{
    public void OpenUrl(string url)
    {
        // UnityEngine.Application : Uygulama çalıştığında veri erişimi.
        Application.OpenURL(url);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class madeira : MonoBehaviour
{  
    public static float increaseRate = 1f;

    public void OnClick ()
    {
        Loja.Click += 10;
    }
}

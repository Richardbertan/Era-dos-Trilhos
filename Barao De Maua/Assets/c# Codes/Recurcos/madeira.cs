using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class madeira : MonoBehaviour
{  
    public static float ClickIncrease = 2f;
    public static float increaseRate = 8f;

    public void OnClick ()
    {
        Loja.Click += ClickIncrease;
    }
}

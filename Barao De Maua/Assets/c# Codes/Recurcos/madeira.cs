using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class madeira : MonoBehaviour
{  
    public static float ClickIncrease = 2f;
    public static float increaseRate = 5f;

    public void OnClick ()
    {
        ClickIncrease = 2f + increaseRate/50;
        Loja.dinFloat += ClickIncrease;
        print (increaseRate);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class madeira : MonoBehaviour
{  
    public static float ClickIncrease = 2f;
    public static float increaseRate;
    
    void OnEnable ()
    {
        increaseRate = 5f;
    } 

    public void OnClick ()
    {
        Loja.dinFloat += ClickIncrease;
    }
}

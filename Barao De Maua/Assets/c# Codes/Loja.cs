using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loja : MonoBehaviour
{
    public static int dinheiro;
    [SerializeField] Text dinhTxt;  
    public static float dinFloat;
    public static float Click;
    void FixedUpdate ()
    {
        dinheiro = (int) dinFloat;
        dinFloat += ((madeira.increaseRate + pedra.increaseRate + carvao.increaseRate + ferro.increaseRate + ouro.increaseRate + diamante.increaseRate) * Time.deltaTime);
        dinhTxt.text = dinheiro.ToString();
            if (Click > 0)
            {
                dinFloat += Click;
                Click = 0;
            }
    }
}
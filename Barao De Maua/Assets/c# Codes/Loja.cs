using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loja : MonoBehaviour
{
    public static int dinheiro;
    int lastMoney = 0;
    [SerializeField] Text dinhTxt;  
    public static float increaseRate;
    public static int Click;
    
    void FixedUpdate ()
    {
        dinheiro = (int) increaseRate;
        increaseRate += ((madeira.increaseRate + pedra.increaseRate + carvao.increaseRate + ferro.increaseRate + ouro.increaseRate + diamante.increaseRate) * Time.deltaTime);
        dinhTxt.text = dinheiro.ToString();
            if (dinheiro > lastMoney)
            {
                lastMoney = dinheiro;
                print("almentou");
            }
            if (Click > 0)
            {
                increaseRate += Click;
                Click = 0;
            }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeGold : MonoBehaviour
{
   public static int Price = 20000;
    public static float PrevPriceActive = 20000f;
    public static float PrevPrice;

    [SerializeField] Text PriTxt;

    public static int PrevValueActive = 50;
    public static int PrevValue;

    void Update ()
    {
        PriTxt.text = Price.ToString();
        print($"{Price} preco ouro");
        print ($"{ouro.increaseRate} valor ouro");
    }

    public void OnClick ()
    {
        if (Loja.dinheiro >= Price)
        {
            PrevValue = (int) ouro.increaseRate;
            ouro.increaseRate += PrevValueActive;
            PrevValueActive = PrevValue;
            Loja.dinFloat -= Price;
            PrevPrice = Price;
            Price += (int) (PrevPriceActive);
            PrevPriceActive = PrevPrice;            
        }
   }
}

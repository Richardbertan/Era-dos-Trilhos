using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeClick : MonoBehaviour
{   
    public static int Price = 700;
    public static float PrevPriceActive = 700f;
    public static float PrevPrice;

    [SerializeField] Text PriTxt;

    public static int PrevValueActive = 8;
    public static int PrevValue;

    void Update ()
    {
        PriTxt.text = Price.ToString();
        print($"{Price} preco Click");
        print ($"{madeira.ClickIncrease} valor click");
    }

    public void OnClick ()
    {
        if (Loja.dinheiro >= Price)
        {
            PrevValue = (int) madeira.ClickIncrease;
            madeira.ClickIncrease += PrevValueActive;
            PrevValueActive = PrevValue;
            Loja.dinFloat -= Price;
            PrevPrice = Price;
            Price += (int) (PrevPriceActive);
            PrevPriceActive = PrevPrice;            
        }
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeWood : MonoBehaviour
{
    int upgradeNum = 0;
    public static int Price = 75;
    public static float PrevPriceActive = 75f;
    public static float PrevPrice;

    [SerializeField] Text PriTxt;

    public static int PrevValueActive = 5;
    public static int PrevValue;

    void Update ()
    {
        PriTxt.text = Price.ToString();
        print($"{Price} preco madeira");
        print ($"{madeira.increaseRate} valor madeira");
    }

    public void OnClick ()
    {
        if (Loja.dinheiro >= Price && upgradeNum <= 6)
        {
            PrevValue = (int) madeira.increaseRate;
            madeira.increaseRate += PrevValueActive * 0.8f;
            PrevValueActive = PrevValue;
            Loja.dinFloat -= Price;
            PrevPrice = Price;
            Price += (int) (PrevPriceActive * 1.2f);
            PrevPriceActive = PrevPrice;    
            upgradeNum ++;        
        }
   }
}

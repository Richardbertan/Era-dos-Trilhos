using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeIron : MonoBehaviour
{
   public static int Price = 7000;
    public static float PrevPriceActive = 7000f;
    public static float PrevPrice;

    [SerializeField] Text PriTxt;

    public static int PrevValueActive = 25;
    public static int PrevValue;

    void Update ()
    {
        PriTxt.text = Price.ToString();
        print($"{Price} preco ferro");
        print ($"{ferro.increaseRate} valor ferro");
    }

    public void OnClick ()
    {
        if (Loja.dinheiro >= Price)
        {
            PrevValue = (int) ferro.increaseRate;
            ferro.increaseRate += PrevValueActive;
            PrevValueActive = PrevValue;
            Loja.dinFloat -= Price;
            PrevPrice = Price;
            Price += (int) (PrevPriceActive);
            PrevPriceActive = PrevPrice;            
        }
   }
}

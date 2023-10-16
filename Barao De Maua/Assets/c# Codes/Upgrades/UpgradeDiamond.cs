using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeDiamond : MonoBehaviour
{
   public static int Price = 70000;
    public static float PrevPriceActive = 70000f;
    public static float PrevPrice;

    [SerializeField] Text PriTxt;

    public static int PrevValueActive = 100;
    public static int PrevValue;

    void Update ()
    {
        PriTxt.text = Price.ToString();
        print($"{Price} preco diamante");
        print ($"{diamante.increaseRate} valor diamante");
    }

    public void OnClick ()
    {
        if (Loja.dinheiro >= Price)
        {
            PrevValue = (int) diamante.increaseRate;
            diamante.increaseRate += PrevValueActive;
            PrevValueActive = PrevValue;
            Loja.dinFloat -= Price;
            PrevPrice = Price;
            Price += (int) (PrevPriceActive);
            PrevPriceActive = PrevPrice;            
        }
   }
}

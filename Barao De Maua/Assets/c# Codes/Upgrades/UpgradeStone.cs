using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeStone : MonoBehaviour
{
   public static int Price = 115;
    [SerializeField] 
    Text PriceTxt;
    void Update ()
    {
    PriceTxt.text = Price.ToString();
    }
   public void OnClick ()
   {
        if (Loja.dinheiro >= Price)
        {
            pedra.increaseRate = 1.2f * pedra.increaseRate;
            Loja.increaseRate -= Price;
            Price += 115;
        }
   }
}

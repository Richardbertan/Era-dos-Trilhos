using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeGold : MonoBehaviour
{
   public static int Price = 100;
    [SerializeField] Text PriTxt;
    void Update ()
    {
    PriTxt.text = Price.ToString();
    }
   public void OnClick ()
   {
        if (Loja.dinheiro >= Price)
        {
            ouro.increaseRate = 1.5f * ouro.increaseRate;
            Price += 0;
        }
   }
}

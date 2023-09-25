using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeGold : MonoBehaviour
{
   public static int Price = 100;
   public void OnClick ()
   {
        if (Loja.dinheiro >= Price)
        {
            ouro.increaseRate = 1.5f * ouro.increaseRate;
            Price += 0;
        }
   }
}

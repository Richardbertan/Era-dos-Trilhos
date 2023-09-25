using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeStone : MonoBehaviour
{
   public static int Price = 100;
   public void OnClick ()
   {
        if (Loja.dinheiro >= Price)
        {
            pedra.increaseRate = 1.5f * pedra.increaseRate;
            Price += 0;
        }
   }
}

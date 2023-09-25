using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeWood : MonoBehaviour
{
   public static int Price = 100;
   public void OnClick ()
   {
        if (Loja.dinheiro >= Price)
        {
            madeira.increaseRate = 1.5f * madeira.increaseRate;
            Price += 0;
        }
   }
}

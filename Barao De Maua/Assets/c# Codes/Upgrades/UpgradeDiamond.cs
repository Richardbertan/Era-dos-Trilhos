using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeDiamond : MonoBehaviour
{
   public static int Price = 100;
   public void OnClick ()
   {
        if (Loja.dinheiro >= Price)
        {
            diamante.increaseRate = 1.5f * diamante.increaseRate;
            Price += 0;
        }
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeIron : MonoBehaviour
{
   public static int Price = 100;
   public void OnClick ()
   {
        if (Loja.dinheiro >= Price)
        {
            ferro.increaseRate = 1.5f * ferro.increaseRate;
            Price += 0;
        }
   }
}

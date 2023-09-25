using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeCoal : MonoBehaviour
{
   public static int Price = 100;
   public void OnClick ()
   {
        if (Loja.dinheiro >= Price)
        {
            carvao.increaseRate = 1.5f * carvao.increaseRate;
            Price += 0;
        }
   }
}

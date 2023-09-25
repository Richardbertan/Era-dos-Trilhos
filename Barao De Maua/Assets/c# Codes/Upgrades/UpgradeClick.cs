using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeClick : MonoBehaviour
{   
    public static int Price = 100;
   public void OnClick ()
   {
        if (Loja.dinheiro >= Price)
        {
            madeira.ClickIncrease = 1.5f * madeira.ClickIncrease;
            Price += 0;
        }
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeDiamond : MonoBehaviour
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
            diamante.increaseRate = 1.5f * diamante.increaseRate;
            Price += 0;
        }
   }
}

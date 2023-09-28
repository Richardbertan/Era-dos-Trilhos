using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeCoal : MonoBehaviour
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
            carvao.increaseRate = 1.5f * carvao.increaseRate;
            Price += 0;
        }
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeIron : MonoBehaviour
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
            ferro.increaseRate = 1.5f * ferro.increaseRate;
            Price += 0;
        }
   }
}

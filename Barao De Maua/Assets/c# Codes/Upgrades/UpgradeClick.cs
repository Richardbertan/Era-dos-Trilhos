using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeClick : MonoBehaviour
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
            madeira.ClickIncrease = 1.1f * madeira.ClickIncrease;
            Loja.increaseRate -= Price;
            Price += 100;
        }
   }
}

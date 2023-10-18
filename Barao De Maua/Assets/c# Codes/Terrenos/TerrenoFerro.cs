using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerrenoFerro : MonoBehaviour
{
    [SerializeField]
    GameObject cadeado;
    
    [SerializeField]
    GameObject ferro;
    
    [SerializeField]
    GameObject Button;
    
    [SerializeField]
    Text PriceTxt;

    int Price = 5000;
    public void OnClick()
    {
        if (Loja.dinheiro >= Price)
        {
            Loja.dinFloat -= Price;
            cadeado.SetActive(false);
            Button.SetActive(false);
            ferro.SetActive(true);
            UpgradeIron.pode = true;
        }
    }

     void start ()
    {
        PriceTxt.text = Price.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerrenoDiam : MonoBehaviour
{
    [SerializeField]
    GameObject cadeado;

    [SerializeField]
    GameObject Dima;
    
    [SerializeField]
    GameObject Button;
    
    [SerializeField]
    Text PriceTxt;

    int Price = 50000;
    public void OnClick()
    {
        if (Loja.dinheiro >= Price)
        {
            Loja.dinFloat -= Price;
            cadeado.SetActive(false);
            Button.SetActive(false);
            Dima.SetActive(true);
        }
    }

    void start ()
    {
        PriceTxt.text = Price.ToString();
    }
}

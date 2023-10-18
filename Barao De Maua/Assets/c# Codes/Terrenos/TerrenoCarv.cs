using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerrenoCarv : MonoBehaviour
{
    [SerializeField]
    GameObject cadeado;

    [SerializeField]
    GameObject Carv;

    [SerializeField]
    GameObject Button;

    [SerializeField]
    Text PriceTxt;

    int Price = 2000;
    public void OnClick()
    {
        if (Loja.dinheiro >= Price)
        {
            Loja.dinFloat -= Price;
            cadeado.SetActive(false);
            Button.SetActive(false);
            Carv.SetActive(true);
            UpgradeCoal.pode = true;
        }
    }

    void start ()
    {
        PriceTxt.text = Price.ToString();
    }
}

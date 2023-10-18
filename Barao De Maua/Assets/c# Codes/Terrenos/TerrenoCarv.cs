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

    public static bool liberado = false;

    int Price = 2000;
    public void OnClick()
    {
        if (Loja.dinheiro >= Price || liberado)
        {
            Loja.dinFloat -= Price;
            cadeado.SetActive(false);
            Button.SetActive(false);
            Carv.SetActive(true);
            UpgradeCoal.pode = true;
            liberado = true;
        }
    }

    void start ()
    {
        PriceTxt.text = Price.ToString();
    }
}

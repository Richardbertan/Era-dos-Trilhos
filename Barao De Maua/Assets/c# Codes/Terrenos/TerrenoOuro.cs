using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerrenoOuro : MonoBehaviour
{
    [SerializeField]
    GameObject cadeado;

    [SerializeField]
    GameObject ouro;
    
    [SerializeField]
    GameObject Button;
    
    [SerializeField]
    Text PriceTxt;

    public static bool liberado = false;

    int Price = 15000;
    public void OnClick()
    {
        if (Loja.dinheiro >= Price || liberado)
        {
            Loja.dinFloat -= Price;
            cadeado.SetActive(false);
            Button.SetActive(false);
            ouro.SetActive(true);
            UpgradeGold.pode = true;
            liberado = true;
        }
    }

    void start ()
    {
        PriceTxt.text = Price.ToString();
    }
}

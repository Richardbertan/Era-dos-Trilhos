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

    public static bool liberado = false;

    int Price = 3500;
    public void OnClick()
    {
        if (Loja.dinheiro >= Price || liberado)
        {
            Loja.dinFloat -= Price;
            cadeado.SetActive(false);
            Button.SetActive(false);
            ferro.SetActive(true);
            UpgradeIron.pode = true;
            liberado = true;
        }
    }

     void start ()
    {
        PriceTxt.text = Price.ToString();
    }

    void Update ()
    {
        if (liberado)
        {
            cadeado.SetActive(false);
            Button.SetActive(false);
            ferro.SetActive(true);
            UpgradeIron.pode = true;
        }
    }
}

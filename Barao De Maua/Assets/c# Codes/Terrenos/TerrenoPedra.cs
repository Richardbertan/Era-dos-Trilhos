using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerrenoPedra : MonoBehaviour
{
    [SerializeField]
    GameObject cadeado;

    [SerializeField]
    GameObject Pedra;

    [SerializeField]
    GameObject Button;

    [SerializeField]
    Text PriceTxt;

    public static bool liberado = false;

    int Price = 500;
    public void OnClick()
    {
        if (Loja.dinheiro >= Price)
        {
            Loja.dinFloat -= Price;
            cadeado.SetActive(false);
            Button.SetActive(false);
            Pedra.SetActive(true);
            UpgradeStone.pode = true;
            liberado = true;
        }
    }

    void Start ()
    {
        PriceTxt.text = Price.ToString();
    }
    void Update ()
    {
        if (liberado)
        {
            cadeado.SetActive(false);
            Button.SetActive(false);
            Pedra.SetActive(true);
            UpgradeStone.pode = true;
        }
    }
}

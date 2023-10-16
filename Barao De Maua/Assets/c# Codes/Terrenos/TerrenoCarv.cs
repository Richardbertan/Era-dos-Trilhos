using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrenoCarv : MonoBehaviour
{
    [SerializeField]
    GameObject cadeado;
    [SerializeField]
    GameObject Carv;
    [SerializeField]
    GameObject Button;
    int Price = 2000;
    public void OnClick()
    {
        if (Loja.dinheiro >= Price)
        {
            Loja.dinFloat -= Price;
            cadeado.SetActive(false);
            Button.SetActive(false);
            Carv.SetActive(true);
        }
    }
}

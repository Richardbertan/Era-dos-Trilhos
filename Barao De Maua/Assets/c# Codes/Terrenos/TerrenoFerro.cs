using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrenoFerro : MonoBehaviour
{
    [SerializeField]
    GameObject cadeado;
    [SerializeField]
    GameObject ferro;
    [SerializeField]
    GameObject Button;
    int Price = 500;
    public void OnClick()
    {
        if (Loja.dinheiro >= Price)
        {
            Loja.dinFloat -= Price;
            cadeado.SetActive(false);
            Button.SetActive(false);
            ferro.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrenoOuro : MonoBehaviour
{
    [SerializeField]
    GameObject cadeado;
    [SerializeField]
    GameObject ouro;
    [SerializeField]
    GameObject Button;
    public void OnClick()
    {
        if (Loja.dinheiro >= 1500)
        {
            Loja.increaseRate -= 1500;
            cadeado.SetActive(false);
            Button.SetActive(false);
            ouro.SetActive(true);
        }
    }
}

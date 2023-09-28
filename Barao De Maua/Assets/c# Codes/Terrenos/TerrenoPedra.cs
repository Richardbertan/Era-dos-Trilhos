using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrenoPedra : MonoBehaviour
{
    [SerializeField]
    GameObject cadeado;
    [SerializeField]
    GameObject Pedra;
    [SerializeField]
    GameObject Button;
    public void OnClick()
    {
        if (Loja.dinheiro >= 375)
        {
            Loja.increaseRate -= 375;
            cadeado.SetActive(false);
            Button.SetActive(false);
            Pedra.SetActive(true);
        }
    }
}

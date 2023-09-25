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
    public void OnClick()
    {
        if (Loja.dinheiro >= 1500)
        {
            Loja.increaseRate -= 1500;
            cadeado.SetActive(false);
            Button.SetActive(false);
            ferro.SetActive(true);
        }
    }
}

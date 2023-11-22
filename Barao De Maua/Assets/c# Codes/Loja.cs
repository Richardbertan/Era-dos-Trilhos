using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loja : MonoBehaviour
{
    public static int dinheiro;

    [SerializeField] Text dinhTxt;  

    public static float dinFloat;

    [SerializeField] int Cheat;

    [SerializeField]
    GameObject Historia;

    [SerializeField]
    GameObject Fim;

    [SerializeField]
    GameObject TutorialObj;

    [SerializeField]
    GameObject recursos;

    static bool Cabo = true;

    static bool Tutorial = true;

    void Start ()
    {
        if (Tutorial)
        {
        Historia.SetActive(true);
        TutorialObj.SetActive(true);
        Tutorial = false;
        }
        if (Tutorial != true)
        {
            recursos.SetActive(true);
        }
    }

    void FixedUpdate ()
    {
        dinheiro = (int) dinFloat;
        dinFloat += Cheat;
        dinFloat += ((madeira.increaseRate + pedra.increaseRate + carvao.increaseRate + ferro.increaseRate + ouro.increaseRate + diamante.increaseRate) * Time.deltaTime);
        dinhTxt.text = dinheiro.ToString();
            
            if (dinheiro >= 500000 && Cabo)
            {
                Fim.SetActive(true);
                Cabo = false;
            }
    }

}
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
    public static float Click;
    [SerializeField]
    GameObject Historia;
    [SerializeField]
    GameObject Fim;
    static bool Cabo = true;
    void Start ()
    {
        Historia.SetActive(true);
    }
    void FixedUpdate ()
    {
        dinheiro = (int) dinFloat;
        dinFloat += Cheat;
        dinFloat += ((madeira.increaseRate + pedra.increaseRate + carvao.increaseRate + ferro.increaseRate + ouro.increaseRate + diamante.increaseRate) * Time.deltaTime);
        dinhTxt.text = dinheiro.ToString();
            if (Click > 0)
            {
                dinFloat += Click;
                Click = 0;
            }
            if (dinheiro >= 500000 && Cabo)
            {
                Fim.SetActive(true);
                Cabo = false;
            }
    }

}
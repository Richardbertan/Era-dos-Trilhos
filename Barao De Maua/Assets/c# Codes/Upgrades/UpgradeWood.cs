using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeWood : MonoBehaviour
{
    public static int PrevPrice = Price;
    public static int Price = 75;

    [SerializeField] Text PriTxt;

    public static int ProssValue;
    public static int PrevValue;

    void Start ()
    {
        PrevValue = (int) madeira.increaseRate;
        print ($"{madeira.increaseRate} valor madeira");
        print ($"{ProssValue} valor pross");
        print ($"{PrevValue} valor prev");
    }
    void Update ()
    {
    PriTxt.text = Price.ToString();
    }

    public void OnClick ()
    {
        print ($"{madeira.increaseRate} valor madeira");
        print ($"{ProssValue} valor pross");
        print ($"{PrevValue} valor prev");

        if (Loja.dinheiro >= Price)
        {
            ProssValue = (int) madeira.increaseRate + PrevValue;
            madeira.increaseRate = ProssValue;
            Loja.increaseRate -= Price;
            Price += 75;
        }

   }
}

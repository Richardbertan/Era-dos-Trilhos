using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeWood : MonoBehaviour
{
    public static int Upgrades = 0;
    public static int Price = 75;
    public static float PrevPriceActive = 75f;
    public static float PrevPrice;

    [SerializeField] Text PriTxt;

    [SerializeField] Text prevValueTxt;
    [SerializeField] Text nextValueTxt;
    public static int nextValue;

    public static float PrevValueActive = 5;
    public static int PrevValue;
 

    void Start ()
    {
        PrevValue = (int) madeira.increaseRate;
        nextValue = (int) (madeira.increaseRate + PrevValueActive);
    }
    
    void Update ()
    {
        PriTxt.text = Price.ToString();
        prevValueTxt.text = PrevValue.ToString();
        nextValueTxt.text = nextValue.ToString(); 
    }

    public void OnClick ()
    {
        if (Loja.dinheiro >= Price && Upgrades <= 6)
        {
            madeira.increaseRate += PrevValueActive;
            PrevValueActive = PrevValue;
            PrevValue = (int) madeira.increaseRate;

            nextValue = (int) (madeira.increaseRate +  PrevValueActive);
            
            Loja.dinFloat -= Price;

            PrevPrice = Price;
            Price += (int) (PrevPriceActive);
            PrevPriceActive = PrevPrice; 

            Upgrades++;    
        }
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeDiamond : MonoBehaviour
{
    public static bool pode = false;
    public static int Upgrades = 0;
   public static int Price = 70000;
    public static float PrevPriceActive = 70000f;
    public static float PrevPrice;

    [SerializeField] Text PriTxt;

    [SerializeField] Text prevValueTxt;
    [SerializeField] Text nextValueTxt;
    public static int nextValue;

    public static int PrevValueActive = 100;
    public static int PrevValue;

    void Start ()
    {
        PrevValue = (int) PrevValueActive;
        nextValue = (int) (PrevValueActive +  PrevValueActive);
    }

    void Update ()
    {
        PriTxt.text = Price.ToString();
        prevValueTxt.text = PrevValue.ToString();
        nextValueTxt.text = nextValue.ToString(); 
    }

    public void OnClick ()
    {
        if (Loja.dinheiro >= Price && Upgrades <= 6 && pode)
        {
            PrevValue = (int) diamante.increaseRate;
            diamante.increaseRate += PrevValueActive;
            PrevValueActive = PrevValue;
            PrevValue = (int) diamante.increaseRate;
            
            nextValue = (int) (diamante.increaseRate +  PrevValueActive);

            Loja.dinFloat -= Price;

            PrevPrice = Price;
            Price += (int) (PrevPriceActive);
            PrevPriceActive = PrevPrice;  

            Upgrades++;          
        }
   }
}

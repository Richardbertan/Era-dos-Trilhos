using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeCoal : MonoBehaviour
{
    public static bool pode = false;
    public static int Upgrades = 0;
   public static int Price = 2500;
    public static float PrevPriceActive = 2500f;
    public static float PrevPrice;

    [SerializeField] Text PriTxt;

    [SerializeField] Text prevValueTxt;
    [SerializeField] Text nextValueTxt;
    public static int nextValue;

    public static int PrevValueActive = 12;
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
            PrevValue = (int) carvao.increaseRate;
            carvao.increaseRate += PrevValueActive;
            PrevValueActive = PrevValue;
            PrevValue = (int) carvao.increaseRate;

            nextValue = (int) (carvao.increaseRate +  PrevValueActive);

            Loja.dinFloat -= Price;

            PrevPrice = Price;
            Price += (int) (PrevPriceActive);
            PrevPriceActive = PrevPrice;  

            Upgrades++;       
        }
   }
}

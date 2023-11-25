using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeIron : MonoBehaviour
{
    public static bool pode = false;
    public static int Upgrades = 0;
   public static int Price = 5000;
    public static float PrevPriceActive = 5000f;
    public static float PrevPrice;

    [SerializeField] Text PriTxt;

    [SerializeField] Text prevValueTxt;
    [SerializeField] Text nextValueTxt;
    public static int nextValue;

    public static int PrevValueActive = 70;
    public static int PrevValue;

    void Start ()
    {
        PrevValue = (int) PrevValueActive;
        nextValue = (int) (PrevValueActive +  PrevValueActive * 1.5f);
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
            PrevValue = (int) ferro.increaseRate;
            ferro.increaseRate += PrevValueActive * 1.5f;
            PrevValueActive = PrevValue;
            PrevValue = (int) ferro.increaseRate;

            nextValue = (int) (ferro.increaseRate +  PrevValueActive * 1.5f);

            Loja.dinFloat -= Price;

            PrevPrice = Price;
            Price += (int) (PrevPriceActive);
            PrevPriceActive = PrevPrice;   

            Upgrades++;       
        }
   }
}

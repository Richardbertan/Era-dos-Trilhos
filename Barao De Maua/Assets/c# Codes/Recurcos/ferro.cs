using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ferro : MonoBehaviour
{
    public static float increaseRate;
    void OnEnable ()
    {
        increaseRate = 10f;
    }
    void OnDisable ()
    {
        increaseRate = 0;
    }
}
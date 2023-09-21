using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carvao : MonoBehaviour
{
    public static float increaseRate;
    void OnEnable ()
    {
        increaseRate = 50f;
    }
    void OnDisable ()
    {
        increaseRate = 0;
    }
}

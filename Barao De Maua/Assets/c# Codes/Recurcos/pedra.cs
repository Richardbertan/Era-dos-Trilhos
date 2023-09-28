using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pedra : MonoBehaviour
{
    public static float increaseRate;
    void OnEnable ()
    {
        increaseRate = 7f;
    }
    void OnDisable ()
    {
        increaseRate = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class diamante : MonoBehaviour
{
    public static float increaseRate;
    void OnEnable ()
    {
        increaseRate = 5000f;
    }
    void OnDisable ()
    {
        increaseRate = 0;
    }
}

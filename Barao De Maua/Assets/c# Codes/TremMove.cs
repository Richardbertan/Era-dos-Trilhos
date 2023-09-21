using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TremMove : MonoBehaviour
{
    [SerializeField]
    GameObject Trem;
    float countDown = 30;
    void Start()
    {
        
    }

    void Update()
    {
        countDown -= 1 * Time.deltaTime;
        if (countDown < 0)
        { 
            countDown += 30;
        }
    }
}

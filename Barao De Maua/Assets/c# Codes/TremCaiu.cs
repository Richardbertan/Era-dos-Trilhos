using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TremCaiu : MonoBehaviour
{
    [SerializeField]
    public GameObject Box;
    [SerializeField]
    public Transform Canvas;
    // Update is called once per frame
    void FixedUpdate()
    {
        print("é isso");
        if (true)
        {
            Sla();
        }
    }
    public void Sla ()
    {
        var position = new Vector2(Random.Range(500f, 1500f), Random.Range(500f, 900f));
        Instantiate(Box, position, Quaternion.identity);
        Box.transform.SetParent(Canvas);
        print (position);
    }
}

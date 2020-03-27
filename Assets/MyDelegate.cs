using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDelegate : MonoBehaviour
{
    delegate void MyDelegateok();
    MyDelegateok myDelegate;

    // Start is called before the first frame update
    void Start()
    {
        myDelegate += powerUp;
      

        myDelegate += turnRedcolor;
        myDelegate();
        
    }
    public void powerUp()
    {
        Debug.Log("Rising power up :");
    }
    public void turnRedcolor()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

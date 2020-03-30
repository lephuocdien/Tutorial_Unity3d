using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllersphere : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        main.ExcuteOnclick += UseGravity;
        
    }
    void UseGravity()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCoin : MonoBehaviour
{
    Vector3 turncoin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        turncoin = new Vector3(45, 0, 0);
        transform.Rotate(turncoin * Time.deltaTime);
    }
}

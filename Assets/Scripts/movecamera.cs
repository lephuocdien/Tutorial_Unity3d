using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecamera : MonoBehaviour
{
    public GameObject ball;
    Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = gameObject.transform.position - ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.transform.position + distance;
    }
}

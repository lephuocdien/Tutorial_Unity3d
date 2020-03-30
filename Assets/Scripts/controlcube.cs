using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlcube : MonoBehaviour
{
    public float timemove = 30f;
    // Start is called before the first frame update
    void TurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    void MoveOtherPosition()
    {
        Vector3 v3 = new Vector3(5,2,0);
        // gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, v3, time);
        // gameObject.transform.position = v3;
       StartCoroutine( MoveLerp(v3) );
    }
    IEnumerator MoveLerp(Vector3 v3)
    {
        
        float i = 0;
        while(i<1)
        {
            i += Time.deltaTime / timemove;
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, v3, i);
            yield return 0;
        }
    }
    void Start()
    {
        main.ExcuteOnclick += TurnRed;
        main.ExcuteOnclick += MoveOtherPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDisable()
    {
        main.ExcuteOnclick -= TurnRed;
    }
}

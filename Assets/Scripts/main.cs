using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class main : MonoBehaviour
{
   // public delegate void OnClickObject();
   // public static event OnClickObject OnClickObjectb;
    public static UnityAction ExcuteOnclick;
    public void ButtonClick()
    {
        if (ExcuteOnclick != null)
            ExcuteOnclick();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDisable()
    {
        
    }
}

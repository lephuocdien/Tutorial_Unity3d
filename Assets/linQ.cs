using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
[System.Serializable]
public class Item
{
    public string name;
    public int itemname;
    public int id;
 
}
public class linQ : MonoBehaviour
{
    public string[] names = {"le","phuoc","dien","le" };
    public int[] arraynb = { 45,75,99,96,78,77};

    public List<Item> items;
    // Start is called before the first frame update
    void Start()
    {
        var namef = names.Any(name=>name=="le");
        var jjj = names.Contains("le");
        var gg = names.Distinct();
        var ddd = arraynb.Where(g => g > 69).OrderByDescending(gdd => gdd);
        foreach (var item in ddd)
        {
            Debug.Log("item : "+ item);

        }
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

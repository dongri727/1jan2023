using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj0 = GameObject.Find("pointer");
        obj0.transform.LookAt(new Vector3(0, 100, 0));


        GameObject obj1 = Instantiate(obj0);
        obj1.name = "Kabul";
        obj1.transform.position = new Vector3(29, 57, 77);
        //obj1.transform.LookAt(new Vector3(0, 100, 0));
    

        GameObject obj2 = Instantiate(obj0);
        obj2.name = "Algiers";
        obj2.transform.position = new Vector3(80, 60, 4);
        //obj2.transform.LookAt(new Vector3(0, 100, 0));
        

        GameObject obj3 = Instantiate(obj0);
        obj3.name = "Luanda";
        obj3.transform.position = new Vector3(96, 15, 23);
        //obj3.transform.LookAt(new Vector3(0, 100, 0));
        


        GameObject obj4 = Instantiate(obj0);
        obj4.name = "Sydney";
        obj4.transform.position = new Vector3(-73, -56, -40);
        //obj4.transform.LookAt(new Vector3(0, 100, 0));


        GameObject obj5 = Instantiate(obj0);
        obj5.name = "Tokyo";
        obj5.transform.position = new Vector3(-62, 58, 53);
        //obj5.transform.LookAt(new Vector3(0, 100, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

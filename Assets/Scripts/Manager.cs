using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj0 = GameObject.Find("pointer");
       
        GameObject obj1 = Instantiate(obj0);
        obj1.name = "pointer1";
        obj1.transform.position = new Vector3(-10, 0, 0);
        obj1.transform.LookAt(new Vector3(0, 0, 50));
    

        GameObject obj2 = Instantiate(obj0);
        obj2.name = "pointer2";
        obj2.transform.position = new Vector3(-5, 0, 0);
        obj2.transform.LookAt(new Vector3(0, 0, 50));
        

        GameObject obj3 = Instantiate(obj0);
        obj3.name = "pointer3";
        obj3.transform.position = new Vector3(5, 0, 0);
        obj3.transform.LookAt(new Vector3(0, 0, 50));
        


        GameObject obj4 = Instantiate(obj0);
        obj4.name = "pointer4";
        obj4.transform.position = new Vector3(10, 0, 0);
        obj4.transform.LookAt(new Vector3(0, 0, 50));


        GameObject obj5 = Instantiate(obj0);
        obj5.name = "pointer5";
        obj5.transform.position = new Vector3(0, 5, 0);
        obj5.transform.LookAt(new Vector3(0, 0, 50));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

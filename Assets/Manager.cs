using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj1.name = "Cube1";
        obj1.transform.position = new Vector3(-3, 0, 0);
        obj1.transform.rotation = Quaternion.Euler(10, 0, 0);
        obj1.GetComponent<Renderer>().material.color = Color.red;

        GameObject obj2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj2.name = "Cube2";
        obj2.transform.position = new Vector3(-1, 0, 0);
        obj2.transform.rotation = Quaternion.Euler(20, 0, 0);
        obj2.GetComponent<Renderer>().material.color = Color.blue;

        GameObject obj3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj3.name = "Cube3";
        obj3.transform.position = new Vector3(1, 0, 0);
        obj3.transform.rotation = Quaternion.Euler(30, 0, 0);
        obj3.GetComponent<Renderer>().material.color = Color.green;


        GameObject obj4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj4.name = "Cube4";
        obj4.transform.position = new Vector3(3, 0, 0);
        obj4.transform.rotation = Quaternion.Euler(40, 0, 0);
        obj4.GetComponent<Renderer>().material.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

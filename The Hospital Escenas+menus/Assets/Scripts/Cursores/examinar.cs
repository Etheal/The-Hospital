using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class examinar : MonoBehaviour
{

    cursor cursor;

    // Use this for initialization
    void Start()
    {
        cursor = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<cursor>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseEnter()
    {
        cursor.SetExaminar();
    }

    void OnMouseExit()
    {
        cursor.SetPuntero();
    }

}

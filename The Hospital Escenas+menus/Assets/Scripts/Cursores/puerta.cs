using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta : MonoBehaviour {

    cursor cursor;

    // Use this for initialization
    void Start () {
        cursor = GameObject.FindWithTag("MainCamera").GetComponent<cursor>();
  
        
   
    }


    void OnMouseEnter()
    {
        cursor.SetPuerta();
    }

    void OnMouseExit()
    {
        cursor.SetPuntero();
    }

}

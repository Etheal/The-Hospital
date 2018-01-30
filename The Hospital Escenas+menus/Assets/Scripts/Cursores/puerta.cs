using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta : MonoBehaviour {

    cursor cursor;

    // Use this for initialization
    void Start () {
        cursor = GameObject.FindWithTag("MainCamera").GetComponent<cursor>();
  
        
   
    }

    // Update is called once per frame
    void Update () {
     if (cursor != null)
        {
            Debug.Log("caca");
        }
        
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

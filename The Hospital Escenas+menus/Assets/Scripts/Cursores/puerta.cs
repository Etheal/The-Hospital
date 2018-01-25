using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta : MonoBehaviour {

    cursor cursor;

    // Use this for initialization
    void Start () {
        cursor = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<cursor>();
    }

    // Update is called once per frame
    void Update () {

    }

    void OnMouseEnter()
    {
        cursor.setPuerta();
    }

    void OnMouseExit()
    {
        cursor.setPuntero();
    }

}

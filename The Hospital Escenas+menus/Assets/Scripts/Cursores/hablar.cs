using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hablar : MonoBehaviour
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
        cursor.setHablar();
    }

    void OnMouseExit()
    {
        cursor.setPuntero();
    }

}

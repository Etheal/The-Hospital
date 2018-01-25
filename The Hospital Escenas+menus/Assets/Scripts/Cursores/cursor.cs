using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour {

    public Texture2D puntero;
    public Texture2D coger;
    public Texture2D puerta;
    public Texture2D examinar;
    public Texture2D hablar;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setPuntero() {
        Cursor.SetCursor(puntero, hotSpot, cursorMode);
    }

    public void setCoger()
    {
        Cursor.SetCursor(coger, hotSpot, cursorMode);
    }

    public void setPuerta()
    {
        Cursor.SetCursor(puerta, hotSpot, cursorMode);
    }

    public void setExaminar()
    {
        Cursor.SetCursor(examinar, hotSpot, cursorMode);
    }

    public void setHablar()
    {
        Cursor.SetCursor(hablar, hotSpot, cursorMode);
    }
}

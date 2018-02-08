using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour {

    public Texture2D puntero;
    public Texture2D coger;
    public Texture2D puerta;
    public Texture2D examinar;
    public Texture2D hablar;
    public Texture2D derecha;
    public Texture2D izquierda;
    public Texture2D abajo;
    public Texture2D puzzle;

    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetPuntero() {
        Cursor.SetCursor(puntero, hotSpot, cursorMode);
    }

    public void SetCoger()
    {
        Cursor.SetCursor(coger, hotSpot, cursorMode);
    }

    public void SetPuerta()
    {
        Cursor.SetCursor(puerta, hotSpot, cursorMode);
    }

    public void SetExaminar()
    {
        Cursor.SetCursor(examinar, hotSpot, cursorMode);
    }

    public void SetHablar()
    {
        Cursor.SetCursor(hablar, hotSpot, cursorMode);
    }

    public void SetPuzzle()
    {
        Cursor.SetCursor(puzzle, hotSpot, cursorMode);
    }

    public void SetDerecha()
    {
        Cursor.SetCursor(derecha, hotSpot, cursorMode);
    }

    public void SetIzquierda()
    {
        Cursor.SetCursor(izquierda, hotSpot, cursorMode);
    }

    public void SetAbajo()
    {
        Cursor.SetCursor(abajo, hotSpot, cursorMode);
    }
}

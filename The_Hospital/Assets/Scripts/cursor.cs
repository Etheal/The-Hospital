using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
	public Text texto;

    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

	public void SetCursor(CursorType.Type cType, string nombreObjeto)
	{
		switch (cType) {
		case CursorType.Type.coger:
			SetCoger (nombreObjeto);
			break;

		case CursorType.Type.examinar:
			SetExaminar (nombreObjeto);
			break;

		case CursorType.Type.hablar:
			SetHablar (nombreObjeto);
			break;

		case CursorType.Type.puerta:
			SetPuerta (nombreObjeto);
			break;

		case CursorType.Type.puzzle:
			SetPuzzle (nombreObjeto);
			break;

		case CursorType.Type.abajo:
			SetAbajo ();
			break;

		case CursorType.Type.derecha:
			SetDerecha ();
			break;

		case CursorType.Type.izquierda:
			SetIzquierda ();
			break;
		}
	}

    public void SetPuntero() {
        Cursor.SetCursor(puntero, hotSpot, cursorMode);
		texto.text = ""; 
    }

	public void SetCoger(string nombreObjeto)
    {
        Cursor.SetCursor(coger, hotSpot, cursorMode);
		texto.text = "Coger " + nombreObjeto;
    }

	public void SetPuerta(string nombreObjeto)
    {
        Cursor.SetCursor(puerta, hotSpot, cursorMode);
		texto.text = "Ir a " + nombreObjeto;
    }

	public void SetExaminar(string nombreObjeto)
    {
        Cursor.SetCursor(examinar, hotSpot, cursorMode);
		texto.text = "Examinar " + nombreObjeto;
    }

	public void SetHablar(string nombreObjeto)
    {
        Cursor.SetCursor(hablar, hotSpot, cursorMode);
		texto.text = "Hablar con " + nombreObjeto;
    }

	public void SetPuzzle(string nombreObjeto)
    {
        Cursor.SetCursor(puzzle, hotSpot, cursorMode);
		texto.text = "Activar " + nombreObjeto;
    }

    public void SetDerecha()
    {
        Cursor.SetCursor(derecha, hotSpot, cursorMode);
		texto.text = "Ir";
    }

    public void SetIzquierda()
    {
        Cursor.SetCursor(izquierda, hotSpot, cursorMode);
		texto.text = "Ir";
    }

    public void SetAbajo()
    {
        Cursor.SetCursor(abajo, hotSpot, cursorMode);
		texto.text = "Ir";
    }
}

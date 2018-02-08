using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorType : MonoBehaviour {

    public enum Type { examinar, coger, puerta, hablar, puzzle, abajo, derecha, izquierda };

    [SerializeField]
    Type puntero;

    public Type GetCursorType()
    {
        return puntero;
    }



}

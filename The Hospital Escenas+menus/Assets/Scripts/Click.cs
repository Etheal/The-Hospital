using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

    [SerializeField]
    private LayerMask clickablesLayer;
    UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter lisasimopson;
    cursor cursor;


    void Start()
    {
        cursor = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<cursor>();

        if (lisasimopson == null)
        {
            GameObject playerGO = GameObject.FindWithTag("Player");
            lisasimopson = playerGO.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter>();
        }
    }

  

    // Update is called once per frame
    void FixedUpdate()
    {

        RaycastHit rayHit;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayHit, Mathf.Infinity, clickablesLayer))
        {
            if (rayHit.collider.GetComponent<CursorType>() != null)
            {
                switch(rayHit.collider.GetComponent<CursorType>().GetCursorType())
                {
                    case CursorType.Type.coger:
                        cursor.SetCoger();
                        break;

                    case CursorType.Type.examinar:
                        cursor.SetExaminar();
                        break;

                    case CursorType.Type.hablar:
                        cursor.SetHablar();
                        break;

                    case CursorType.Type.puerta:
                        cursor.SetPuerta();
                        break;
                    case CursorType.Type.puzzle:
                        cursor.SetPuzzle();
                        break;
                    case CursorType.Type.abajo:
                        cursor.SetAbajo();
                        break;
                    case CursorType.Type.derecha:
                        cursor.SetDerecha();
                        break;
                    case CursorType.Type.izquierda:
                        cursor.SetIzquierda();
                        break;
                }
            }
            else
            {
                cursor.SetPuntero();
            }

            if (Input.GetMouseButtonDown(0))
            {              
                if (rayHit.collider.GetComponent<spawnPoint>() != null)                  
                {
                    rayHit.collider.GetComponent<spawnPoint>().CrossDoor(lisasimopson);
                }
            }

        }
        else
        {
            cursor.SetPuntero();
        }
    }
}


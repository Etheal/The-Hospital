using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class Click : MonoBehaviour {

    [SerializeField]
    private LayerMask clickablesLayer;
    ThirdPersonCharacter lisasimopson;
	[SerializeField]cursor cursor;

	bool cursorIn = false;
	public Text texto;
    public GameObject objetivoTrigger;
    public Vector3 posicionActual;
	int numFrameRayo = 0;
	int numFrameClic= 0;

    void Start()
    {

		if (lisasimopson == null)
        {
            GameObject playerGO = GameObject.FindWithTag("Player");
            lisasimopson = playerGO.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter>();
        }
    }
		
    // Update is called once per frame

	public void FixedUpdate()
	{


		if (!cursorIn) return;
		
		RaycastHit rayHit;
			
		if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out rayHit, Mathf.Infinity, clickablesLayer))
		{
			if (rayHit.collider.GetComponent<CursorType>() != null)
			{
				cursor.SetCursor (rayHit.collider.GetComponent<CursorType> ().GetCursorType (), rayHit.collider.GetComponent<Objetos> ().GetObjeto ());

			} else {
				cursor.SetPuntero();

			}
				

			if (Input.GetButtonDown("Fire1"))
			{
                objetivoTrigger = rayHit.collider.gameObject;

                if (rayHit.collider.GetComponent<spawnPoint>() != null)                  
				{

					rayHit.collider.GetComponent<spawnPoint>().CrossDoor(lisasimopson);
				}

					
				else if (lisasimopson!= null)
				{
					lisasimopson.GetComponent<AICharacterControl>().SetTarget (rayHit.point);
                    posicionActual = lisasimopson.GetComponent<AICharacterControl>().target;

                }
			}
		}
	}

    public GameObject GetObjetivoTrigger()
    {
        return objetivoTrigger;
    }

    public void entro()
	{
		cursorIn = true;
	}

	public void salgo()
	{
		cursorIn = false;
	}

    public Vector3 GetPosicionActual(Vector3 posicionActual)
    {
        return posicionActual;
    }
}


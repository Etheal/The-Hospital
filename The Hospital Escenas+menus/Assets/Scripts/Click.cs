using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

    [SerializeField]
    private LayerMask clickablesLayer;
    UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter lisasimopson;

    void Start()
    {
        if (lisasimopson == null)
        {
            GameObject playerGO = GameObject.FindWithTag("Player");
            lisasimopson = playerGO.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter>();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("Calculo logica");
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit rayHit;
            Debug.Log("Rayo");

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayHit, Mathf.Infinity, clickablesLayer))
            {
                Debug.Log(rayHit.collider.gameObject.name);
              
                if (rayHit.collider.GetComponent<spawnPoint>() != null)
                   
                {
                    Debug.Log(rayHit.collider.gameObject.name);
                    rayHit.collider.GetComponent<spawnPoint>().CrossDoor(lisasimopson);
                }
            }

       }
    }
    void Update()
    {
        Debug.Log("Pinto");
    }
}


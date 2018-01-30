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
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit rayHit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayHit, Mathf.Infinity, clickablesLayer))
            {
              
                if (rayHit.collider.GetComponent<spawnPoint>() != null)
                   
                {

                    rayHit.collider.GetComponent<spawnPoint>().CrossDoor(lisasimopson);
                }
            }

       }
    }
}


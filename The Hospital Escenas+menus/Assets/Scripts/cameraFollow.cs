using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

    public Transform follow;


    void Start () 
    {
        follow = GameObject.Find("Sarah").transform;
    }

	void Update () {

        transform.LookAt(follow, new Vector3 (0, 0.5f, 0));
	}
}

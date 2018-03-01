using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

    public Transform follow;
	[SerializeField] float speed = 1;

    void Start () 
    {
        follow = GameObject.Find("Sarah").transform;
    }

	void Update () {

		Quaternion targetRotation = Quaternion.LookRotation(follow.position - transform.position);

		// Smoothly rotate towards the target point.
		transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);

		//transform.LookAt(Vector3.Lerp(transform.position,follow.position,Time.deltaTime* speed), new Vector3 (0, 0.5f, 0));
	}
}

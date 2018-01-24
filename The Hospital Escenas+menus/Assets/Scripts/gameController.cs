using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
       
        SceneManager.LoadScene(2, LoadSceneMode.Additive);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

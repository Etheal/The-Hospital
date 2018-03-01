using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetos : MonoBehaviour {

	[SerializeField]
	string objeto;

    [SerializeField]
    string descripion;

	public string GetObjeto()
	{
		return objeto;
	}

    public string GetDescripcion()
    {
        return descripion;
    }

}


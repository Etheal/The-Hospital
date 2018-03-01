using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPrueba : MonoBehaviour
{
    [SerializeField]
    string texto;

    [SerializeField]
    Sprite sprite;

    [SerializeField]
    GameObject itemObject;
    // public SomeOther thing;

	public Sprite GetSprite()
	{
		return sprite;
	}

    public string GetString()
    {
        return texto;
    }
}

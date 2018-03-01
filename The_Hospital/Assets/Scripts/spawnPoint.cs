using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.ThirdPerson;

public class spawnPoint : MonoBehaviour {

    [SerializeField]
    GameObject _spawnPoint;
    [SerializeField]
    int sceneToUnload;
    [SerializeField]
    int sceneToload;
    [SerializeField]
    fade fade;

    Vector3 posicion;

	UnityEngine.AI.NavMeshAgent agent;

    public void CrossDoor(UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter character)
    {
        StartCoroutine(_CrossDoor(character));
		agent = character.GetComponent<UnityEngine.AI.NavMeshAgent> ();
    }


    IEnumerator _CrossDoor(UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter character)
    {
        fade.FadeIn();

        while (fade.IsFading())
        {
            yield return null;
        }

        Vector3 posicionDestino = _spawnPoint.transform.position;
		Vector3 rotacionDestino = _spawnPoint.transform.eulerAngles;

		agent.enabled = false;
        character.transform.position = posicionDestino;
        character.transform.eulerAngles = rotacionDestino;
		agent.enabled = true;

        SceneManager.UnloadSceneAsync(sceneToUnload);
        AsyncOperation ao = SceneManager.LoadSceneAsync(sceneToload, LoadSceneMode.Additive);

        while (!ao.isDone)
        {
            yield return null;
        }

        fade.FadeOut();

        GameObject.Find("Button").GetComponent<Click>().GetPosicionActual(posicion);
        GameObject.Find("Sarah").GetComponent<AICharacterControl>().SetTarget(posicionDestino);

    }

}

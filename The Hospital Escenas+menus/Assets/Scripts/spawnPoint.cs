using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnPoint : MonoBehaviour {

    [SerializeField]
    GameObject _spawnPoint;
    [SerializeField]
    int sceneToUnload;
    [SerializeField]
    int sceneToload;
    [SerializeField]
    fade fade;

    public void CrossDoor(UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter character)
    {
        StartCoroutine(_CrossDoor(character));
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

        character.transform.position = posicionDestino;
        character.transform.eulerAngles = rotacionDestino;

        SceneManager.UnloadSceneAsync(sceneToUnload);
        AsyncOperation ao = SceneManager.LoadSceneAsync(sceneToload, LoadSceneMode.Additive);

        while (!ao.isDone)
        {
            yield return null;
        }

        fade.FadeOut();

    }

}

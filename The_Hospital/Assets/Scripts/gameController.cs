using System.Collections;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class gameController : MonoBehaviour {

    public static gameController gameCont;

    public float playerPositionX;
    public float playerPositionY;
    public float playerPositionZ;

    void Awake()
    {
        if (gameCont == null)
        {
            DontDestroyOnLoad(gameObject);
            gameCont = this;
        }
        else if (gameCont != this)
        {
            Destroy(gameObject);
        }
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        //Crea un Object para guardar los datos
        PlayerData data = new PlayerData();
        data.playerPosX = playerPositionX;
        data.playerPosY = playerPositionY;
        data.playerPosZ = playerPositionZ;

        //Escribe el Object en el archivo y cierra
        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);

            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            playerPositionX = data.playerPosX;
            playerPositionY = data.playerPosY;
            playerPositionZ = data.playerPosZ;
        }
    }

    public void Delete()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            File.Delete(Application.persistentDataPath + "/playerInfo.dat");
        }
    }


[Serializable]
class PlayerData
{
    public float playerPosX;
    public float playerPosY;
    public float playerPosZ;
}


    [SerializeField]
    bool pasado = false;

	[SerializeField]
	GameObject intro;

    [SerializeField]
    GameObject musica;

	[SerializeField]
	Text texto;

	Image introImagen;
	Color color;
	float alpha = 0f;



    public bool GetEpoca()
    {
        return pasado;
    }


	// Use this for initialization
	void Start ()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Additive); 

		introImagen = intro.GetComponent<Image>();
    }
		

	// Update is called once per frame
	void Update () {

		color = introImagen.color;

		if (color.a  <= alpha) 
		{						
            musica.SetActive(true);
			StartCoroutine (ActivarFrasesIntro());
			intro.SetActive(false);
		}
	}


	IEnumerator ActivarFrasesIntro ()
	{
		texto.text = "Uhm... Qué extraño...";
		yield return new WaitForSeconds (5);

		texto.text = "Este sitio parece abandonado.";
		yield return new WaitForSeconds (5);

		texto.text = "Quizá consiga entrar y averiguar";
		yield return new WaitForSeconds (5);

		texto.text = "qué es lo que ha pasado";
		yield return new WaitForSeconds (5);

		texto.text = null;
					
	}
}


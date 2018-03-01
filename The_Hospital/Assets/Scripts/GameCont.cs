using System.Collections;
using System;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class GameCont : MonoBehaviour
{
    public static GameCont gameCont;

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
        else if(gameCont != this)
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
        if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
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
        if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            File.Delete(Application.persistentDataPath + "/playerInfo.dat");
        }
    }
}

[Serializable]
class PlayerData
{
    public float playerPosX;
    public float playerPosY;
    public float playerPosZ;
}

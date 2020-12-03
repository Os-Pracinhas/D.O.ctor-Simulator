using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer(Player player){

        DirectoryInfo d = new DirectoryInfo(Application.persistentDataPath);
        string count = null;
        if(d.GetFiles().Length == 0) count = "0";
        else if(d.GetFiles().Length > 0) count = (d.GetFiles().Length).ToString();

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath+"/player"+count+".fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData[] LoadPlayers(){
        
        DirectoryInfo d = new DirectoryInfo(Application.persistentDataPath);
        int files_tam = d.GetFiles().Length;
        string path;
        BinaryFormatter formatter = new BinaryFormatter();
        PlayerData[] data = new PlayerData[files_tam];

        if(files_tam > 0){
            
            for (int i = 0; i < files_tam; i++)
            {
                path = Application.persistentDataPath+"/player"+(i)+".fun";
                FileStream stream = new FileStream(path, FileMode.Open);
                data[i] = formatter.Deserialize(stream) as PlayerData;
                stream.Close();
            }
            
            

            return data;
        }
        else
        {
            Debug.LogError("Save file not found");
            return null;
        }
    }

    public static PlayerData Search(string nome){
        DirectoryInfo d = new DirectoryInfo(Application.persistentDataPath);
        int files_tam = d.GetFiles().Length;
        string path;
        BinaryFormatter formatter = new BinaryFormatter();
        PlayerData data;
        for (int i = 0; i < files_tam; i++)
        {
            path = Application.persistentDataPath+"/player"+i+".fun";
            FileStream stream = new FileStream(path, FileMode.Open);

            data = formatter.Deserialize(stream) as PlayerData;
            if(data.name == nome){
                stream.Close();
                return data;
            }
            stream.Close();
        }

        return null;
    }
}

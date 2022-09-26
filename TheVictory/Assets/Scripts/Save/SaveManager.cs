using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveManager
{
    public static void SaveData<T>(T data,string path, string fileName)
    {
        string fullPath = Application.persistentDataPath + "/" + path + "/";
        bool checkFolderExit = Directory.Exists(fullPath);
        //Debug.Log(fullPath);
        if (checkFolderExit == false)
        {
            Directory.CreateDirectory(fullPath);
            
        }
        //Debug.Log(data);    
        string json = JsonUtility.ToJson(data);
        //Debug.Log(json);
        File.WriteAllText(fullPath + fileName + ".json", json);
    }
    
    public static T LoadData<T>(string path, string fileName)
    {
        string fullPath = Application.persistentDataPath + "/" + path + "/" + fileName + ".json";
        if (File.Exists(fullPath))
        {
            string textJson = File.ReadAllText(fullPath);
            var obj = JsonUtility.FromJson<T>(textJson);
            return obj;
        }
        else
        {
            Debug.Log("Error");
            return default;
        }
    }
    
}

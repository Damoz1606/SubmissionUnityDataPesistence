using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PersistentData
{
    private string dataPath = Application.dataPath + System.IO.Path.DirectorySeparatorChar + "GameData.json";

    private static PersistentData _instance;
    public static PersistentData Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new PersistentData();
            }

            return _instance; ;
        }
    }

    public void SavePersistentData(string username, float score)
    {
        SaveData data = new SaveData();
        data.username = username;
        data.score = score;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(dataPath, json);
    }

    public SaveData LoadData()
    {
        if (File.Exists(dataPath))
        {
            string json = File.ReadAllText(dataPath);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            return data;
        }

        return null;
    }

    [System.Serializable]
    public class SaveData
    {
        public string username;
        public float score;
    }
}

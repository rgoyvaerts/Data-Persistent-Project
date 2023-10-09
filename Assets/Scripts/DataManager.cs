//- - - - - - - - - - - - - - - - - - - - - - - - - - -//
// Data persistence between scenes & sessions
//- - - - - - - - - - - - - - - - - - - - - - - - - - -//


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    // Start is called before the first frame update: void Start() { }

    // Update is called once per frame: void Update() { }

    public static DataManager Instance { get; private set; }

    public int score;
    public int highscore;
    public string username;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadData();
    }

    [System.Serializable]

    class SaveData
    {
        public int score;
        public int highscore;
        public string username;
    }

    public void WriteData()
    {
        SaveData data = new SaveData();
        data.score = score;
        data.highscore = highscore;
        data.username = username;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        Debug.Log("Data Saved to: " + Application.persistentDataPath);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json); //Read the string as a json data structure and assign the properties of the Class SaveData like color, speed, etc. to the class object (data)
            score = data.score;
            highscore = data.highscore;
            username = data.username;
            Debug.Log("Data Loaded from: " + Application.persistentDataPath);
        }
    }


}
using System.IO;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    // Start() and update() methods deleted - we don't need them right now

    public static MainManager Instance;

    public Color TeamColor;

    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        // Ensure only one instance of MainManager exists
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        // Set the instance to this object
        Instance = this;
        DontDestroyOnLoad(gameObject);

        // Load the team color from persistent storage
        LoadColor();
    }

    // Data structure to hold the color data for saving/loading
    [System.Serializable]
    class SaveData
    {
        public Color TeamColor;
    }

    public void SaveColor()
    {
        // Create a new SaveData object and populate it with the current team color
        SaveData data = new SaveData();
        data.TeamColor = TeamColor;

        // Convert the SaveData object to a JSON string
        string json = JsonUtility.ToJson(data);

        // Write the JSON string to a file in the persistent data path
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadColor()
    {
        // Construct the file path
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            // Read the JSON string from the file
            string json = File.ReadAllText(path);
            // Convert the JSON string back to a SaveData object
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            TeamColor = data.TeamColor;
        }
    }
}
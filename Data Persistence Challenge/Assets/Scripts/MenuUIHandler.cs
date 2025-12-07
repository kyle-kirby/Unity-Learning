using TMPro;
//using UnityEditor.Overlays;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_Text highScoreText;
    public static string PlayerName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (System.IO.File.Exists(path))
        {
            string json = System.IO.File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            nameInput.text = data.LastPlayerName;
            highScoreText.text = $"Best Score : {data.HighScorePlayer} : {data.HighScore}";
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        PlayerName = nameInput.text;
        SceneManager.LoadScene(1);
    }
}

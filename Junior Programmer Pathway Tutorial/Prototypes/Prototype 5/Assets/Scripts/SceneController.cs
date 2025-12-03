using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Called by UI buttons
    public void LoadPrototypeScene(string sceneName)
    {
        SceneManager.LoadScene("Prototype 5");
    }

    public void LoadChallengeScene(string sceneName)
    {
        SceneManager.LoadScene("Challenge 5");

    }


    void Update()
    {
        // Press ESC to return to Main Menu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void LoadRunningScene()
    {
        SceneManager.LoadScene("Prototype 3"); // Replace with your actual scene name
    }

    public void LoadBalloonScene()
    {
        SceneManager.LoadScene("Challenge 3"); // Replace with your actual scene name
    }
}
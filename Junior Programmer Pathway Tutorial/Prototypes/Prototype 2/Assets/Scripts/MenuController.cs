using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void LoadFeedScene()
    {
        SceneManager.LoadScene("Prototype 2"); // Replace with your actual scene name
    }

    public void LoadFetchScene()
    {
        SceneManager.LoadScene("Challenge 2"); // Replace with your actual scene name
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void LoadTruckScene()
    {
        SceneManager.LoadScene("Prototype 1"); // Truck scene
    }

    public void LoadPlaneScene()
    {
        SceneManager.LoadScene("Challenge 1"); // Plane scene
    }
}
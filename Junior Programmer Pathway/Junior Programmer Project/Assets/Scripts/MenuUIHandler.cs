using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public ColorPicker ColorPicker;

    public void NewColorSelected(Color color)
    {
        // add code here to handle when a color is selected
        MainManager.Instance.TeamColor = color;
    }
    
    private void Start()
    {
        ColorPicker.Init();
        //this will call the NewColorSelected function when the color picker have a color button clicked.
        ColorPicker.onColorChanged += NewColorSelected;

        //Set the color picker to the current team color
        ColorPicker.SelectColor(MainManager.Instance.TeamColor);
    }

    public void StartNew()
    {
        MainManager.Instance.SaveColor();
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        // Save the team color before exiting
        MainManager.Instance.SaveColor();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    // Save the team color when the save button is clicked
    public void SaveColorClicked()
    {
        MainManager.Instance.SaveColor();
    }

    // Load the team color when the load button is clicked
    public void LoadColorClicked()
    {
        MainManager.Instance.LoadColor();
        // Update the color picker to reflect the loaded color
        ColorPicker.SelectColor(MainManager.Instance.TeamColor);
    }
}

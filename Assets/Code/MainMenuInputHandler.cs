using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuInputHandler : MonoBehaviour {
    
    public void OnPlayButton()
    {
        Debug.Log("Loading 'Gameplay' Scene...");
        // Application.LoadLevel("Gameplay");
    }

    public void OnInstructionsButton()
    {
        Debug.Log("Showing Instructions...");
    }

    public void OnExitButton()
    {
        Debug.Log("Exiting Application...");
        Application.Quit();
    }

}

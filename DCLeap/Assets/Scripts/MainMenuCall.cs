using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuCall : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("OpenMenu"))
        {
            SceneManager.UnloadSceneAsync("DCLeap");
            SceneManager.LoadScene("Menu");
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("Menu")); // interet de cette ligne ???
       }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Leap.Unity
{
    public class SceneManaging : MonoBehaviour
    {

    public void LoadVirtualMouse()
        {
            SceneManager.LoadScene("DCLeap");
        }

        public void LoadHelp()
        {
            SceneManager.UnloadSceneAsync("Menu");
            SceneManager.LoadScene("Help");
        }

        public void LoadMainMenu()
        {
            SceneManager.UnloadSceneAsync("Help");
            SceneManager.LoadScene("Menu");
        }

        public void UnLoadVirtualMouse()
        {
            SceneManager.UnloadSceneAsync("DCLeap");
            SceneManager.LoadScene("Menu");
        }

        public void VirtualMouseEnd()
        {
            
            Application.Quit();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttoncontrol : MonoBehaviour
{
    public void MainScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ARscene()
    {
        SceneManager.LoadScene("AR");
    }
    public void Exit()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtoncontrolScreen : MonoBehaviour
{
    public GameObject UI;

    public void MainScene()
    {
        UI.SetActive(false);
        SceneManager.LoadScene("MainMenu");
    }

    private IEnumerator Screenshot()
    {
        yield return new WaitForEndOfFrame();
        Texture2D texture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);

        texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        texture.Apply();

        string name = "Screenshot" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".png";

        NativeGallery.SaveImageToGallery(texture, "Myapp pictures", name);

        Destroy(texture);
        UI.SetActive(true);

    }

    public void TakeScreenshot()
    {
        UI.SetActive(false);
        StartCoroutine("Screenshot");
    }

    public void OpenZ()
    {
        UI.SetActive(false);
        Application.OpenURL("https://docs.google.com/forms/d/1LSqbL031RxOqCLXI_k8e-HSUiqepA75dDxVXy2dkOIo/viewform?edit_requested=true");
    }

}

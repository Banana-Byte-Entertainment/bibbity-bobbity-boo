using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("SampleScene2");
    }

    public void Quit()
    {
        Application.Quit();
    }
}

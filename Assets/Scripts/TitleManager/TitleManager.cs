using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
   public void OnStartButton()
    {
        SceneManager.LoadScene("Game");
    }
    public void OnwayofplayingButton()
    {
        SceneManager.LoadScene("Wayofplaying");
    }
    public void OnBackButton()
    {
        SceneManager.LoadScene("Title");
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMainPage : MonoBehaviour
{
    [SerializeField, Header("リトライボタン")]　private UIButton _retryButton;
    [SerializeField, Header("Resultボタン")]　private UIButton _resultButton;
    private void Start()
    {
        _retryButton.OnClickAddListener(OnClickRetryButton);
        _resultButton.OnClickAddListener(OnClickTitleButton);
    }

    private static void OnClickRetryButton()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }

    private static void OnClickTitleButton()
    {
        SceneManager.LoadScene("GameResult");
    }
}

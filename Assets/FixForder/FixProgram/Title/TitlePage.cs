using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Title画面を管理
public class TitlePage : MonoBehaviour
{
    [SerializeField,Header("スタートボタン")] private UIButton _startButton;
    [SerializeField, Header("遊び方ボタン")] private UIButton _descriptionButton;
    [SerializeField, Header("Audio")] private AudioSource _audioSource;

    public void Start()
    {
        _startButton.OnClickAddListener(OnChangeStartScene);
        _descriptionButton.OnClickAddListener(OnChangeDescriptionScene);
        _audioSource.Play();
    }
    
    //Gameをスタート
    public void OnChangeStartScene()
    {
        SceneManager.LoadScene("Game");
    }
    
    public void OnChangeDescriptionScene()
    {
        SceneManager.LoadScene("Wayofplaying");
    }
}

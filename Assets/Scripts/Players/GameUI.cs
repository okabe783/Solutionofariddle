using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] Text _turnResultText; 
    [SerializeField] Text _platerLifeText;
    [SerializeField] Text _enemyLifeText;
    [SerializeField] GameObject _resultPanel;
    [SerializeField] Text _resultText;
    //手札を初期化する
    public void Init()
    {
        _resultPanel.gameObject.SetActive(false);
        _resultText.gameObject.SetActive(false);
    }
    //playerとenemyのライフを表示
    public void ShowLife(int _playerLife, int _enemyLife)
    {
        _platerLifeText.text = $"x{_playerLife}";
        _enemyLifeText.text = $"x{_enemyLife}";
    }
    //ターンの結果を表示
    public void ShowTurnResult(string result)
    {
        _turnResultText.gameObject.SetActive(true);
        _turnResultText.text = result;
    }
    //ゲームの最終結果を表示
    public void ShowGameResult(string result)
    {
        _resultPanel.SetActive(true);
        _resultText.text = result;
    }
    public void SetPanel(string result)
    {
        _resultPanel.gameObject.SetActive(true);
        _resultText.text = result;
    }
    public void SetUpNextTurn()
    {
        _turnResultText.gameObject.SetActive(false);
    }
}

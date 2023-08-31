using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] Text _turnResultText; //ê¨å˜Ç©é∏îsÇ©
    [SerializeField] Text _platerLifeText;Å@
    [SerializeField] Text _enemyLifeText;
    [SerializeField] GameObject _resultPanel;Å@
    [SerializeField] Text _resultText;
    public void Init()
    {
        _resultPanel.gameObject.SetActive(false);
        _resultText.gameObject.SetActive(false);
    }
    public void ShowLife(int _playerLife, int _enemyLife)
    {
        _platerLifeText.text = $"x{_playerLife}";
        _enemyLifeText.text = $"x{_enemyLife}";
    }
    public void ShowTurnResult(string result)
    {
        _turnResultText.gameObject.SetActive(true);
        _turnResultText.text = result;
    }

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
}

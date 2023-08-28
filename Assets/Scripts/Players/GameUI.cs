using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] Text _platerLifeText;
    [SerializeField] Text _enemyLifeText;
    [SerializeField] GameObject _resultPanel;
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
    public void SetPanel(string result)
    {
        _resultPanel.gameObject.SetActive(true);
        _resultText.text = result;
    }
}

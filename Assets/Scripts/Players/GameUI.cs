using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] Text _platerLifeText;
    [SerializeField] Text _enemyLifeText;

    public void ShowLife(int _playerLife, int _enemyLife)
    {
        _platerLifeText.text = $"x{_playerLife}";
        _enemyLifeText.text = $"x{_enemyLife}";
    }
}

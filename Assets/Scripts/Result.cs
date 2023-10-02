using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    [SerializeField] Text _resultText;
    [SerializeField] ResultData _resultData;
    [SerializeField] Text _enemyCardResult;
    [SerializeField] Text _enemyCardResult2;

    private void Start()
    {
        ShowResult();
        ShowEnemyAttribute();
    }
    private void ShowResult()
    {
        if (_resultData.Result == GameManager.MatchData.WIN)
        {
            _resultText.text = "WIN";
        }
        else
        {
            _resultText.text = "LOSE";
        }
    }
    private void ShowEnemyAttribute()
    {
        _enemyCardResult.text = _resultData.CardList[0];
        if (_resultData.CardList.Count == 1 ) return;
        _enemyCardResult2.text = _resultData.CardList[1];
    }
}

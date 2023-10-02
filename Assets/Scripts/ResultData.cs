using System.Collections.Generic;
using UnityEngine;
using static GameManager;

[CreateAssetMenu]
public class ResultData : ScriptableObject
{
    private MatchData _result;
   [SerializeField] List<string> _cardList = new ();

    public MatchData Result => _result;

    public List<string> CardList => _cardList;

    public void SetResult(MatchData matchData)
    {
        _result = matchData;
    }
    public void SetEnemyAttribute(string card)
    {
        _cardList.Add(card);
    }
    public void ResetMatchData()
    {
        _cardList = null;
    }
}

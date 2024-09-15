using System.Collections.Generic;
using UnityEngine;

/// <summary>Cardの生成を管理</summary>
public class FixCardGenerator : MonoBehaviour
{
    [SerializeField, Header("Cardの情報")] private　List<CardBase> _cardBases = new();
    [SerializeField, Header("Cardのプレハブ")]　private Card _cardPrefab;
    
    /// <summary>プレイヤーにカードをランダムに配り、手札の位置をリセットする</summary>
    public void PlayerSendCard(Player player)
    {
        for (int i = 0; i < 3; i++)
        {
            Card card = Spawn();
        }
        player.Hand.ResetPosition();
    }
    
    //Cardを生成する
    private Card Spawn()
    {
        int randomIndex = Random.Range(0, _cardBases.Count);
        Card card = Instantiate(_cardPrefab);
        card.CardSet(_cardBases[randomIndex]);
        return card;
    }
}
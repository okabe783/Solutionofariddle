using System;
using UnityEngine;
public class RuleBook : MonoBehaviour
{
    //結果の表示
    public void Result(Player _player, Enemy _enemy)
    {
        CardType myCard = CardType.None;
        EnemyType enemyType = EnemyType.None;

        // カードの評価を行うここから
        if (myCard.HasFlag(CardType.Sword) && enemyType.HasFlag(EnemyType.Green))
        {
            _player.Life -= 1;
        }
    }
}
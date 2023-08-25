using System;
using UnityEngine;
public class RuleBook : MonoBehaviour
{
    //結果の表示
    public void Result(Player _player, Enemy _enemy)
    {
        CardType myCard = CardType.None;
        EnemyType enemyType = EnemyType.None;

        // カードの評価を行う
        //プレイヤーのカードが剣で敵の魔石が赤、青、緑の時
        if (myCard.HasFlag(CardType.Sword) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Green))))
        {
            _enemy.Life -= 1;
        }
        //プレイヤーのカードが剣で敵の魔石が黄色の時
        if (myCard.HasFlag(CardType.Sword) && (enemyType.HasFlag(EnemyType.Yellow)))
        {
            _player.Life -= 1;
        }
        //プレイヤーのカードが盾で敵の魔石が赤、青、黄色の時
        if (myCard.HasFlag(CardType.Shield) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _enemy.Life -= 1;
        }
        //プレイヤーのカードが盾で敵の魔石が緑の時
        if (myCard.HasFlag(CardType.Shield) && (enemyType.HasFlag(EnemyType.Green)))
        {
            _player.Life -= 1;
        }
        //プレイヤーのカードが槍で敵の魔石が赤緑黄色の時
        if (myCard.HasFlag(CardType.Spear) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _enemy.Life -= 1;
        }
        //プレイヤーのカードが槍で敵の魔石が青の時
        if (myCard.HasFlag(CardType.Spear) && (enemyType.HasFlag(EnemyType.Blue)))
        {
            _player.Life -= 1;
        }
        //プレイヤーのカードが弓で敵の魔石が青緑黄色の時
        if (myCard.HasFlag(CardType.Bow) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _enemy.Life -= 1;
        }
        //プレイヤーのカードが弓で敵の魔石が赤の時
        if (myCard.HasFlag(CardType.Bow) && (enemyType.HasFlag(EnemyType.Red)))
        {
            _player.Life -= 1;
        }
    }
}
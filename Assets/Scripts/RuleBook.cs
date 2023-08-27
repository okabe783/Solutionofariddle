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
        //プレイヤーのカードが槍で敵の魔石が赤、緑、黄色の時
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
        //プレイヤーのカードが弓で敵の魔石が青、緑、黄色の時
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
        //プレイヤーのカードが銃で敵の魔石が赤、青の時
        if (myCard.HasFlag(CardType.Gun) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))))
        {
            _enemy.Life -= 2;
        }
        //プレイヤーのカードが銃で敵の魔石が緑、黄色の時
        if (myCard.HasFlag(CardType.Gun) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _player.Life -= 2;
        }
        //プレイヤーのカードが拳で敵の魔石が赤、緑の時
        if (myCard.HasFlag(CardType.Fist) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))))
        {
            _enemy.Life -= 2;
        }
        //プレイヤーのカードが拳で敵の魔石が青、黄色の時
        if (myCard.HasFlag(CardType.Fist) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _player.Life -= 2;
        }
        //プレイヤーのカードが回復で敵の魔石が赤、黄色の時
        if (myCard.HasFlag(CardType.Heal) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _enemy.Life -= 2;
        }
        //プレイヤーのカードが回復で敵の魔石が青、緑の時
        if (myCard.HasFlag(CardType.Heal) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))))
        {
            _player.Life -= 2;
        }
        //プレイヤーのカードが必殺技で敵の魔石が青、緑の時
        if (myCard.HasFlag(CardType.Special) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))))
        {
            _enemy.Life -= 2;
        }
        //  プレイヤーのカードが必殺技で敵の魔石が赤、黄色の時
        if (myCard.HasFlag(CardType.Special) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _player.Life -= 2;
        }
        //プレイヤーのカードが手裏剣で敵の魔石が青、黄色の時
        if (myCard.HasFlag(CardType.Shuriken) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _enemy.Life -= 2;
        }
        //プレイヤーのカードが手裏剣で敵の魔石が赤、黄色の時
        if (myCard.HasFlag(CardType.Shuriken) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _player.Life -= 2;
        }
        //プレイヤーのカードが斧で敵の魔石が緑、黄色の時
        if (myCard.HasFlag(CardType.Axe) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _enemy.Life -= 2;
        }
        //プレイヤーのカードが斧で敵の魔石が赤、青の時
        if (myCard.HasFlag(CardType.Shuriken) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))))
        {
            _player.Life -= 2;
        }
        //プレイヤーのカードが杖で敵の魔石が赤の時
        if (myCard.HasFlag(CardType.Staff) && (enemyType.HasFlag(EnemyType.Red)))
        {
            _enemy.Life -= 3;
        }
        //プレイヤーのカードが杖で敵の魔石が青、黄色、緑の時 
        if (myCard.HasFlag(CardType.Staff) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _player.Life -= 3;
        }
        //プレイヤーのカードがマシンガンで敵の魔石が青の時
        if (myCard.HasFlag(CardType.Machinegun) && (enemyType.HasFlag(EnemyType.Blue)))
        {
            _enemy.Life -= 3;
        }
        //プレイヤーのカードがマシンガンで敵の魔石が赤、黄色、緑の時 
        if (myCard.HasFlag(CardType.Staff) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _player.Life -= 3;
        }
        //プレイヤーのカードが爆弾で敵の魔石が緑の時
        if (myCard.HasFlag(CardType.Bomb) && (enemyType.HasFlag(EnemyType.Green)))
        {
            _enemy.Life -= 3;
        }
        //プレイヤーのカードがマシンガンで敵の魔石が赤、黄色、青の時 
        if (myCard.HasFlag(CardType.Bomb) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _player.Life -= 3;
        }
        //プレイヤーのカードが大鎌で敵の魔石が黄色の時
        if (myCard.HasFlag(CardType.Scythe) && (enemyType.HasFlag(EnemyType.Yellow)))
        {
            _enemy.Life -= 3;
        }
        //プレイヤーのカードがマシンガンで敵の魔石が赤、緑、青の時 
        if (myCard.HasFlag(CardType.Bomb) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Green))))
        {
            _player.Life -= 3;
        }
    }
    public enum TurnResult
    {
        Success,
        Failure,
        Win,
        Lose,
    }
}
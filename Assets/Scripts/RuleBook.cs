using UnityEngine;
public class RuleBook : MonoBehaviour
{
    //結果の表示
    public TurnResult Result(Player _player, Enemy _enemy)
    {
        CardType myCard = CardType.None;
        EnemyType enemyType = EnemyType.None;

        // カードの評価を行う
        //プレイヤーのカードが剣で敵の魔石が赤、青、緑の時
        if (myCard.HasFlag(CardType.Sword) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Green))))
        {
            return TurnResult.Success1;
        }
        //プレイヤーのカードが剣で敵の魔石が黄色の時
        if (myCard.HasFlag(CardType.Sword) && (enemyType.HasFlag(EnemyType.Yellow)))
        {
            return TurnResult.Failure1;
        }
        //プレイヤーのカードが盾で敵の魔石が赤、青、黄色の時
        if (myCard.HasFlag(CardType.Shield) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Success1;
        }
        //プレイヤーのカードが盾で敵の魔石が緑の時
        if (myCard.HasFlag(CardType.Shield) && (enemyType.HasFlag(EnemyType.Green)))
        {
            return TurnResult.Failure1;
        }
        //プレイヤーのカードが槍で敵の魔石が赤、緑、黄色の時
        if (myCard.HasFlag(CardType.Spear) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Success1;
        }
        //プレイヤーのカードが槍で敵の魔石が青の時
        if (myCard.HasFlag(CardType.Spear) && (enemyType.HasFlag(EnemyType.Blue)))
        {
            return TurnResult.Failure1;
        }
        //プレイヤーのカードが弓で敵の魔石が青、緑、黄色の時
        if (myCard.HasFlag(CardType.Bow) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Success1;
        }
        //プレイヤーのカードが弓で敵の魔石が赤の時
        if (myCard.HasFlag(CardType.Bow) && (enemyType.HasFlag(EnemyType.Red)))
        {
            return TurnResult.Failure1;
        }
        //プレイヤーのカードが銃で敵の魔石が赤、青の時
        if (myCard.HasFlag(CardType.Gun) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))))
        {
            return TurnResult.Success2;
        }
        //プレイヤーのカードが銃で敵の魔石が緑、黄色の時
        if (myCard.HasFlag(CardType.Gun) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Failure2;
        }
        //プレイヤーのカードが拳で敵の魔石が赤、緑の時
        if (myCard.HasFlag(CardType.Fist) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))))
        {
            return TurnResult.Success2;
        }
        //プレイヤーのカードが拳で敵の魔石が青、黄色の時
        if (myCard.HasFlag(CardType.Fist) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Failure2;
        }
        //プレイヤーのカードが回復で敵の魔石が赤、黄色の時
        if (myCard.HasFlag(CardType.Heal) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Success2;
        }
        //プレイヤーのカードが回復で敵の魔石が青、緑の時
        if (myCard.HasFlag(CardType.Heal) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))))
        {
            return TurnResult.Failure2;
        }
        //プレイヤーのカードが必殺技で敵の魔石が青、緑の時
        if (myCard.HasFlag(CardType.Special) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))))
        {
            return TurnResult.Success2;
        }
        //  プレイヤーのカードが必殺技で敵の魔石が赤、黄色の時
        if (myCard.HasFlag(CardType.Special) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Failure2;
        }
        //プレイヤーのカードが手裏剣で敵の魔石が青、黄色の時
        if (myCard.HasFlag(CardType.Shuriken) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Success2;
        }
        //プレイヤーのカードが手裏剣で敵の魔石が赤、黄色の時
        if (myCard.HasFlag(CardType.Shuriken) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Failure2;
        }
        //プレイヤーのカードが斧で敵の魔石が緑、黄色の時
        if (myCard.HasFlag(CardType.Axe) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Success2;
        }
        //プレイヤーのカードが斧で敵の魔石が赤、青の時
        if (myCard.HasFlag(CardType.Shuriken) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))))
        {
            return TurnResult.Failure2;
        }
        //プレイヤーのカードが杖で敵の魔石が赤の時
        if (myCard.HasFlag(CardType.Staff) && (enemyType.HasFlag(EnemyType.Red)))
        {
            return TurnResult.Success3;
        }
        //プレイヤーのカードが杖で敵の魔石が青、黄色、緑の時 
        if (myCard.HasFlag(CardType.Staff) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Failure3;
        }
        //プレイヤーのカードがマシンガンで敵の魔石が青の時
        if (myCard.HasFlag(CardType.Machinegun) && (enemyType.HasFlag(EnemyType.Blue)))
        {
            return TurnResult.Success3;
        }
        //プレイヤーのカードがマシンガンで敵の魔石が赤、黄色、緑の時 
        if (myCard.HasFlag(CardType.Staff) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Failure3;
        }
        //プレイヤーのカードが爆弾で敵の魔石が緑の時
        if (myCard.HasFlag(CardType.Bomb) && (enemyType.HasFlag(EnemyType.Green)))
        {
            return TurnResult.Success3;
        }
        //プレイヤーのカードがマシンガンで敵の魔石が赤、黄色、青の時 
        if (myCard.HasFlag(CardType.Bomb) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Failure3;
        }
        //プレイヤーのカードが大鎌で敵の魔石が黄色の時
        if (myCard.HasFlag(CardType.Scythe) && (enemyType.HasFlag(EnemyType.Yellow)))
        {
            return TurnResult.Success3;
        }
        //プレイヤーのカードがマシンガンで敵の魔石が赤、緑、青の時 
        if (myCard.HasFlag(CardType.Bomb) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Green))))
        {
            return TurnResult.Failure3;
        }
        return TurnResult.None;
    }
    public enum TurnResult
    {
        None,
        Success1,
        Success2,
        Success3,
        Failure1,
        Failure2,
        Failure3,
        GameWin,
        GameLose,
    }
}
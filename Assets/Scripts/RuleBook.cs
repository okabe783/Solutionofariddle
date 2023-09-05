using UnityEngine;
public class RuleBook : MonoBehaviour
{
    //結果の表示
    public TurnResult Result(Player _player, Enemy _enemy)
    {
        PlayerType myCard = PlayerType.None;
        EnemyType enemyType = EnemyType.None;
        // カードの評価を行う
        //プレイヤーのカードが剣で敵の魔石が赤、青、緑の時
        if (myCard.HasFlag(PlayerType.Kizaki) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("剣で攻撃をした");
            return TurnResult.Success1;
        }
        //プレイヤーのカードが剣で敵の魔石が黄色の時
        if (myCard.HasFlag(PlayerType.Kizaki) && (enemyType.HasFlag(EnemyType.Yellow)))
        {
            Debug.Log("剣で攻撃をしたが失敗");
            return TurnResult.Failure1;
        }
        //プレイヤーのカードが盾で敵の魔石が赤、青、黄色の時
        if (myCard.HasFlag(PlayerType.Hasiwaka) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("盾で攻撃をした");
            return TurnResult.Success1;
        }
        //プレイヤーのカードが盾で敵の魔石が緑の時
        if (myCard.HasFlag(PlayerType.Hasiwaka) && (enemyType.HasFlag(EnemyType.Green)))
        {
            Debug.Log("盾で攻撃をしたが失敗");
            return TurnResult.Failure1;
        }
        //プレイヤーのカードが槍で敵の魔石が赤、緑、黄色の時
        if (myCard.HasFlag(PlayerType.Itadaki) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("槍で攻撃をした");
            return TurnResult.Success1;
        }
        //プレイヤーのカードが槍で敵の魔石が青の時
        if (myCard.HasFlag(PlayerType.Itadaki) && (enemyType.HasFlag(EnemyType.Blue)))
        {
            Debug.Log("槍で攻撃をしたが失敗");
            return TurnResult.Failure1;
        }
        //プレイヤーのカードが弓で敵の魔石が青、緑、黄色の時
        if (myCard.HasFlag(PlayerType.Nanase) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("弓で攻撃をした");
            return TurnResult.Success1;
        }
        //プレイヤーのカードが弓で敵の魔石が赤の時
        if (myCard.HasFlag(PlayerType.Nanase) && (enemyType.HasFlag(EnemyType.Red)))
        {
            Debug.Log("弓で攻撃をしたが失敗");
            return TurnResult.Failure1;
        }
        //プレイヤーのカードが銃で敵の魔石が赤、青の時
        if (myCard.HasFlag(PlayerType.Hyakuti) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))))
        {
            Debug.Log("銃で攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードが銃で敵の魔石が緑、黄色の時
        if (myCard.HasFlag(PlayerType.Hyakuti) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("銃で攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードが拳で敵の魔石が赤、緑の時
        if (myCard.HasFlag(PlayerType.Kimata) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("拳で攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードが拳で敵の魔石が青、黄色の時
        if (myCard.HasFlag(PlayerType.Kimata) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("拳で攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードが回復で敵の魔石が赤、黄色の時
        if (myCard.HasFlag(PlayerType.Yuzuki) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("回復で攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードが回復で敵の魔石が青、緑の時
        if (myCard.HasFlag(PlayerType.Yuzuki) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("回復で攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードが必殺技で敵の魔石が青、緑の時
        if (myCard.HasFlag(PlayerType.Yukime) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("必殺技で攻撃をした");
            return TurnResult.Success2;
        }
        //  プレイヤーのカードが必殺技で敵の魔石が赤、黄色の時
        if (myCard.HasFlag(PlayerType.Yukime) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("必殺技で攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードが手裏剣で敵の魔石が青、黄色の時
        if (myCard.HasFlag(PlayerType.Inukai) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("手裏剣で攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードが手裏剣で敵の魔石が赤、黄色の時
        if (myCard.HasFlag(PlayerType.Inukai) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("手裏剣で攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードが斧で敵の魔石が緑、黄色の時
        if (myCard.HasFlag(PlayerType.Tennoji) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("斧で攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードが斧で敵の魔石が赤、青の時
        if (myCard.HasFlag(PlayerType.Tennoji) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))))
        {
            Debug.Log("斧で攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードが杖で敵の魔石が赤の時
        if (myCard.HasFlag(PlayerType.Risia) && (enemyType.HasFlag(EnemyType.Red)))
        {
            Debug.Log("杖で攻撃をした");
            return TurnResult.Success3;
        }
        //プレイヤーのカードが杖で敵の魔石が青、黄色、緑の時 
        if (myCard.HasFlag(PlayerType.Risia) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("杖で攻撃をしたが失敗");
            return TurnResult.Failure3;
        }
        //プレイヤーのカードがマシンガンで敵の魔石が青の時
        if (myCard.HasFlag(PlayerType.Kurofusi) && (enemyType.HasFlag(EnemyType.Blue)))
        {
            Debug.Log("マシンガンで攻撃をした");
            return TurnResult.Success3;
        }
        //プレイヤーのカードがマシンガンで敵の魔石が赤、黄色、緑の時 
        if (myCard.HasFlag(PlayerType.Kurofusi) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("マシンガンで攻撃をしたが失敗");
            return TurnResult.Failure3;
        }
        //プレイヤーのカードが爆弾で敵の魔石が緑の時
        if (myCard.HasFlag(PlayerType.Kongoji) && (enemyType.HasFlag(EnemyType.Green)))
        {
            Debug.Log("爆弾で攻撃をした");
            return TurnResult.Success3;
        }
        //プレイヤーのカードが爆弾で敵の魔石が赤、黄色、青の時 
        if (myCard.HasFlag(PlayerType.Kongoji) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("爆弾で攻撃をしたが失敗");
            return TurnResult.Failure3;
        }
        //プレイヤーのカードが大鎌で敵の魔石が黄色の時
        if (myCard.HasFlag(PlayerType.Yorugami) && (enemyType.HasFlag(EnemyType.Yellow)))
        {
            Debug.Log("大鎌で攻撃をした");
            return TurnResult.Success3;
        }
        //プレイヤーのカード大鎌で敵の魔石が赤、緑、青の時 
        if (myCard.HasFlag(PlayerType.Yorugami) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("大鎌で攻撃をしたが失敗");
            return TurnResult.Failure3;
        }
        Debug.Log("ここだけはよばないでください");
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
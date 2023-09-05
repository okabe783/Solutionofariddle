using UnityEngine;
public class RuleBook : MonoBehaviour
{
    //結果の表示
    public TurnResult Result(Player _player, Enemy _enemy)
    {
        PlayerType myCard = PlayerType.None;
        EnemyType enemyType = EnemyType.None;
        // カードの評価を行う
        //プレイヤーのカードがKizakiで敵の魔石が赤、青、緑の時
        if (myCard.HasFlag(PlayerType.Kizaki) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("Kizakiで攻撃をした");
            return TurnResult.Success1;
        }
        //プレイヤーのカードがKizakiで敵の魔石が黄色の時
        if (myCard.HasFlag(PlayerType.Kizaki) && (enemyType.HasFlag(EnemyType.Yellow)))
        {
            Debug.Log("Kizakiで攻撃をしたが失敗");
            return TurnResult.Failure1;
        }
        //プレイヤーのカードがHasiwakaで敵の魔石が赤、青、黄色の時
        if (myCard.HasFlag(PlayerType.Hasiwaka) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Hasiwakaで攻撃をした");
            return TurnResult.Success1;
        }
        //プレイヤーのカードがHasiwakaで敵の魔石が緑の時
        if (myCard.HasFlag(PlayerType.Hasiwaka) && (enemyType.HasFlag(EnemyType.Green)))
        {
            Debug.Log("Hasiwakaで攻撃をしたが失敗");
            return TurnResult.Failure1;
        }
        //プレイヤーのカードがItadakiで敵の魔石が赤、緑、黄色の時
        if (myCard.HasFlag(PlayerType.Itadaki) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Itadakiで攻撃をした");
            return TurnResult.Success1;
        }
        //プレイヤーのカードがItadakiで敵の魔石が青の時
        if (myCard.HasFlag(PlayerType.Itadaki) && (enemyType.HasFlag(EnemyType.Blue)))
        {
            Debug.Log("Itadakiで攻撃をしたが失敗");
            return TurnResult.Failure1;
        }
        //プレイヤーのカードがNanaseで敵の魔石が青、緑、黄色の時
        if (myCard.HasFlag(PlayerType.Nanase) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Nanaseで攻撃をした");
            return TurnResult.Success1;
        }
        //プレイヤーのカードがNanaseで敵の魔石が赤の時
        if (myCard.HasFlag(PlayerType.Nanase) && (enemyType.HasFlag(EnemyType.Red)))
        {
            Debug.Log("Nanaseで攻撃をしたが失敗");
            return TurnResult.Failure1;
        }
        //プレイヤーのカードがHyakutiで敵の魔石が赤、青の時
        if (myCard.HasFlag(PlayerType.Hyakuti) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))))
        {
            Debug.Log("Hyakutiで攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードがHyakutiで敵の魔石が緑、黄色の時
        if (myCard.HasFlag(PlayerType.Hyakuti) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Hyakutiで攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードがKimataで敵の魔石が赤、緑の時
        if (myCard.HasFlag(PlayerType.Kimata) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("Kimataで攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードがKimataで敵の魔石が青、黄色の時
        if (myCard.HasFlag(PlayerType.Kimata) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Kimataで攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードがYuzukiで敵の魔石が赤、黄色の時
        if (myCard.HasFlag(PlayerType.Yuzuki) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Yuzukiで攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードがYuzukiで敵の魔石が青、緑の時
        if (myCard.HasFlag(PlayerType.Yuzuki) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("Yuzukiで攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードがYukimeで敵の魔石が青、緑の時
        if (myCard.HasFlag(PlayerType.Yukime) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("Yukimeで攻撃をした");
            return TurnResult.Success2;
        }
        //  プレイヤーのカードがYukimeで敵の魔石が赤、黄色の時
        if (myCard.HasFlag(PlayerType.Yukime) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Yukimeで攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードがInukaiで敵の魔石が青、黄色の時
        if (myCard.HasFlag(PlayerType.Inukai) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Inukaiで攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードがInukaiで敵の魔石が赤、黄色の時
        if (myCard.HasFlag(PlayerType.Inukai) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Inukaiで攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードがTennojiで敵の魔石が緑、黄色の時
        if (myCard.HasFlag(PlayerType.Tennoji) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Tennojiで攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードがTennojiで敵の魔石が赤、青の時
        if (myCard.HasFlag(PlayerType.Tennoji) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))))
        {
            Debug.Log("Tennojiで攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードがRisiaで敵の魔石が赤の時
        if (myCard.HasFlag(PlayerType.Risia) && (enemyType.HasFlag(EnemyType.Red)))
        {
            Debug.Log("Risiaで攻撃をした");
            return TurnResult.Success3;
        }
        //プレイヤーのカードがRisiaで敵の魔石が青、黄色、緑の時 
        if (myCard.HasFlag(PlayerType.Risia) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Risiaで攻撃をしたが失敗");
            return TurnResult.Failure3;
        }
        //プレイヤーのカードがKurofusiで敵の魔石が青の時
        if (myCard.HasFlag(PlayerType.Kurofusi) && (enemyType.HasFlag(EnemyType.Blue)))
        {
            Debug.Log("Kurofusiで攻撃をした");
            return TurnResult.Success3;
        }
        //プレイヤーのカードがKurofusiで敵の魔石が赤、黄色、緑の時 
        if (myCard.HasFlag(PlayerType.Kurofusi) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Kurofusiで攻撃をしたが失敗");
            return TurnResult.Failure3;
        }
        //プレイヤーのカードがKongojiで敵の魔石が緑の時
        if (myCard.HasFlag(PlayerType.Kongoji) && (enemyType.HasFlag(EnemyType.Green)))
        {
            Debug.Log("Kongojiで攻撃をした");
            return TurnResult.Success3;
        }
        //プレイヤーのカードがKongojiで敵の魔石が赤、黄色、青の時 
        if (myCard.HasFlag(PlayerType.Kongoji) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Kongojiで攻撃をしたが失敗");
            return TurnResult.Failure3;
        }
        //プレイヤーのカードがYorugamiで敵の魔石が黄色の時
        if (myCard.HasFlag(PlayerType.Yorugami) && (enemyType.HasFlag(EnemyType.Yellow)))
        {
            Debug.Log("Yorugamiで攻撃をした");
            return TurnResult.Success3;
        }
        //プレイヤーのカードYorugamiで敵の魔石が赤、緑、青の時 
        if (myCard.HasFlag(PlayerType.Yorugami) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("Yorugamiで攻撃をしたが失敗");
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
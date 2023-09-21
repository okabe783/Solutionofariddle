using UnityEngine;
public class RuleBook : MonoBehaviour
{
    //結果の表示
    public TurnResult Result(PlayerType player, EnemyType enemy)
    {
        PlayerType myCard = player;
        EnemyType enemyType = enemy;
        //4属性を対象
        //プレイヤーのカードがYanagiで敵の魔石が青、緑、金、紫の時
        if (myCard.HasFlag(PlayerType.Yanagi) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green)
           || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Yanagiで攻撃をした");
            return TurnResult.Success1;
        }
        //プレイヤーのカードがYanagiで敵の魔石が赤、黄色、白の時
        if (myCard.HasFlag(PlayerType.Yanagi) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Yanagiで攻撃をしたが失敗");
            return TurnResult.Failure1;
        }
        //プレイヤーのカードがKougaで敵の魔石が黄色、紫、白、赤の時　
        if (myCard.HasFlag(PlayerType.Kouga) && (enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.White) || enemyType.HasFlag(EnemyType.Red)))
        {
            Debug.Log("Kougaで攻撃をした");
            return TurnResult.Success1;
        }
        //プレイヤーのカードがKougaで敵の魔石が青、緑、金の時
        if (myCard.HasFlag(PlayerType.Kouga) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Kougaで攻撃をしたが失敗");
            return TurnResult.Failure1;
        }
        //プレイヤーのカードがGengaで敵の魔石が金、赤、紫、緑の時　
        if (myCard.HasFlag(PlayerType.Genma) && (enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Green)))
        {
            Debug.Log("Genmaで攻撃をした");
            return TurnResult.Success1;
        }
        //プレイヤーのカードがGengaで敵の魔石が青、黄色、白の時
        if (myCard.HasFlag(PlayerType.Genma) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Genmaで攻撃をしたが失敗");
            return TurnResult.Failure1;
        }
        //プレイヤーのカードがKizakiで敵の魔石が紫、金、白、青の時　
        if (myCard.HasFlag(PlayerType.Kizaki) && (enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.White) || enemyType.HasFlag(EnemyType.Blue)))
        {
            Debug.Log("Kizakiで攻撃をした");
            return TurnResult.Success1;
        }
        //プレイヤーのカードがKizakiで敵の魔石が赤、黄色、緑の時
        if (myCard.HasFlag(PlayerType.Kizaki) && enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Green))
        {
            Debug.Log("Kizakiで攻撃をしたが失敗");
            return TurnResult.Failure1;
        }
        //プレイヤーのカードがHasiwakaで敵の魔石が赤、緑、黄色、金の時
        if (myCard.HasFlag(PlayerType.Hasiwaka) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Hasiwakaで攻撃をした");
            return TurnResult.Success1;
        }
        //プレイヤーのカードがHasiwakaで敵の魔石が青、紫、白の時
        if (myCard.HasFlag(PlayerType.Hasiwaka) && enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.White))
        {
            Debug.Log("Hasiwakaで攻撃をしたが失敗");
            return TurnResult.Failure1;
        }
        //プレイヤーのカードがItadakiで敵の魔石が青、緑、金、紫の時
        if (myCard.HasFlag(PlayerType.Itadaki) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Itadakiで攻撃をした");
            return TurnResult.Success1;
        }
        //プレイヤーのカードがItadakiで敵の魔石が赤、黄色、白の時
        if (myCard.HasFlag(PlayerType.Itadaki) && enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.White))
        {
            Debug.Log("Itadakiで攻撃をしたが失敗");
            return TurnResult.Failure1;
        }
        //プレイヤーのカードがNanaseで敵の魔石が白、紫、黄色、赤の時
        if (myCard.HasFlag(PlayerType.Nanase) && (enemyType.HasFlag(EnemyType.White) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Red)))
        {
            Debug.Log("Nanaseで攻撃をした");
            return TurnResult.Success1;
        }
        //プレイヤーのカードがNanaseで敵の魔石が青、緑、金の時
        if (myCard.HasFlag(PlayerType.Nanase) && enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Gold))
        {
            Debug.Log("Nanaseで攻撃をしたが失敗");
            return TurnResult.Failure1;
        }
        //プレイヤーのカードがHyakutiで敵の魔石が緑、金、赤、青の時
        if (myCard.HasFlag(PlayerType.Hyakuti) && (enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue)))
        {
            Debug.Log("Hyakutiで攻撃をした");
            return TurnResult.Success1;
        }
        //プレイヤーのカードがHyakutiで敵の魔石が紫、黄色、白の時
        if (myCard.HasFlag(PlayerType.Hyakuti) && (enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Hyakutiで攻撃をしたが失敗");
            return TurnResult.Failure1;
        }
        //プレイヤーのカードがYaibaで敵の魔石が赤、黄色、紫、白の時
        if (myCard.HasFlag(PlayerType.Yaiba) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Yaibaで攻撃をした");
            return TurnResult.Success1;
        }
        //プレイヤーのカードがYaibaで敵の魔石が青、緑、金の時
        if (myCard.HasFlag(PlayerType.Yaiba) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Yaibaで攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードがKimataで敵の魔石が青、紫、金、黄色の時
        if (myCard.HasFlag(PlayerType.Kimata) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Yellow)))
        {
            Debug.Log("Kimataで攻撃をした");
            return TurnResult.Success1;
        }
        //プレイヤーのカードがKimataで敵の魔石が青、黄色、白の時
        if (myCard.HasFlag(PlayerType.Kimata) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Kimataで攻撃をしたが失敗");
            return TurnResult.Failure1;
        }
        //プレイヤーのカードがManamiで敵の魔石が緑、金、青、紫の時
        if (myCard.HasFlag(PlayerType.Manami) && (enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Manamiで攻撃をした");
            return TurnResult.Success1;
        }
        //プレイヤーのカードがManamiで敵の魔石が赤、黄色、白の時
        if (myCard.HasFlag(PlayerType.Manami) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Manamiで攻撃をしたが失敗");
            return TurnResult.Failure1;
        }
        //プレイヤーのカードがOtogiで敵の魔石が黄色、白、赤、緑の時
        if (myCard.HasFlag(PlayerType.Otogi) && (enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.White) || enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Green)))
        {
            Debug.Log("Otogiで攻撃をした");
            return TurnResult.Success1;
        }
        //プレイヤーのカードがOtogiで敵の魔石が青、金、紫の時
        if (myCard.HasFlag(PlayerType.Otogi) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Otogiで攻撃をしたが失敗");
            return TurnResult.Failure1;
        }

        //3属性を対象
        //プレイヤーのカードがYuzukiで敵の魔石が赤、青、緑の時
        if (myCard.HasFlag(PlayerType.Yuzuki) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green)))
        {
            Debug.Log("Yuzukiで攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードがYuzukiで敵の魔石が黄色、紫、白,、金の時
        if (myCard.HasFlag(PlayerType.Yuzuki) && (enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.White) || enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Yuzukiで攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードがYukimeで敵の魔石が黄色、紫、金の時
        if (myCard.HasFlag(PlayerType.Yukime) && (enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Yukimeで攻撃をした");
            return TurnResult.Success2;
        }
        //  プレイヤーのカードがYukimeで敵の魔石が赤、青、緑、白の時
        if (myCard.HasFlag(PlayerType.Yukime) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Yukimeで攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードがInukaiで敵の魔石が金、赤、白の時
        if (myCard.HasFlag(PlayerType.Inukai) && (enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Inukaiで攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードがInukaiで敵の魔石が青、黄色、緑、紫の時
        if (myCard.HasFlag(PlayerType.Yukime) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Inukaiで攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードがTennojiで敵の魔石が紫、金、白の時
        if (myCard.HasFlag(PlayerType.Tennoji) && (enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Tennojiで攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードがTennojiで敵の魔石が赤、青、黄色、緑の時
        if (myCard.HasFlag(PlayerType.Tennoji) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Green)))
        {
            Debug.Log("Tennojiで攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードがParaberamuで敵の魔石が青、緑、紫の時
        if (myCard.HasFlag(PlayerType.Paraberamu) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Paraberamuで攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードがParaberamuで敵の魔石が赤、黄色、金、白の時
        if (myCard.HasFlag(PlayerType.Paraberamu) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Paraberamuで攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードがMabosiで敵の魔石が黄色、緑、金の時
        if (myCard.HasFlag(PlayerType.Mabosi) && (enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Mabosiで攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードがMabosiで敵の魔石が赤、青、白、紫の時
        if (myCard.HasFlag(PlayerType.Mabosi) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.White) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Mabosiで攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードがSimaで敵の魔石が赤、黄色、白の時
        if (myCard.HasFlag(PlayerType.Sima) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Simaで攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードがSimaで敵の魔石が緑、青、金、紫の時
        if (myCard.HasFlag(PlayerType.Sima) && (enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Simaで攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードがYurakiで敵の魔石が青、金、紫の時
        if (myCard.HasFlag(PlayerType.Yuraki) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Yurakiで攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードがYurakiで敵の魔石が赤、緑、白、紫の時
        if (myCard.HasFlag(PlayerType.Yuraki) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.White) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Yurakiで攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードがRisiaで敵の魔石が緑、黄色、紫の時
        if (myCard.HasFlag(PlayerType.Risia) && (enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Risiaで攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードがRisiaで敵の魔石が赤、青、金、白の時 
        if (myCard.HasFlag(PlayerType.Risia) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Risiaで攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードがKurofusiで敵の魔石が赤、黄色、金の時
        if (myCard.HasFlag(PlayerType.Kurofusi) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Kurofusiで攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードがKurofusiで敵の魔石が青、緑、白、紫の時 
        if (myCard.HasFlag(PlayerType.Kurofusi) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.White) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Kurofusiで攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードがKongojiで敵の魔石が青、緑、白の時
        if (myCard.HasFlag(PlayerType.Kongoji) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Kongojiで攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードがKongojiで敵の魔石が赤、黄色、紫、金の時 
        if (myCard.HasFlag(PlayerType.Kongoji) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Kongojiで攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードがYorugamiで敵の魔石が赤、黄色、紫の時
        if (myCard.HasFlag(PlayerType.Yorugami) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Yorugamiで攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードYorugamiで敵の魔石が青、緑、白、金の時 
        if (myCard.HasFlag(PlayerType.Yorugami) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.White) || enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Yorugamiで攻撃をしたが失敗");
            return TurnResult.Failure2;
        }
        //プレイヤーのカードがSabitaniで敵の魔石が赤、青、黄色の時
        if (myCard.HasFlag(PlayerType.Sabitani) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue)
         || enemyType.HasFlag(EnemyType.Yellow)))
        {
            Debug.Log("Sabitaniで攻撃をした");
            return TurnResult.Success2;
        }
        //プレイヤーのカードがSabitaniで敵の魔石が緑、白、紫、金の時
        if (myCard.HasFlag(PlayerType.Sabitani) && (enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.White)
         || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Sabitaniで攻撃をしたが失敗");
            return TurnResult.Failure2;
        }

        //1属性を対象
        //プレイヤーのカードがHaisikiで敵の魔石が赤の時
        if (myCard.HasFlag(PlayerType.Haisiki) && enemyType.HasFlag(EnemyType.Red))
        {
            Debug.Log("Haisikiで攻撃をした");
            return TurnResult.Success3;
        }
        //プレイヤーのカードがHaisikiで敵の魔石が青、緑、黄色、紫、金、白の時
        if (myCard.HasFlag(PlayerType.Haisiki) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green)
            || enemyType.HasFlag(EnemyType.Yellow)) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.White))
        {
            Debug.Log("Haisikiで攻撃をしたが失敗");
            return TurnResult.Failure3;
        }
        //プレイヤーのカードがRyutanで敵の魔石が青の時
        if (myCard.HasFlag(PlayerType.Ryutan) && enemyType.HasFlag(EnemyType.Blue))
        {
            Debug.Log("Ryutanで攻撃をした");
            return TurnResult.Success3;
        }
        //プレイヤーのカードがRyutanで敵の魔石が赤、緑、黄色、紫、金、白の時
        if (myCard.HasFlag(PlayerType.Ryutan) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Green)
            || enemyType.HasFlag(EnemyType.Yellow)) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.White))
        {
            Debug.Log("Ryutanで攻撃をしたが失敗");
            return TurnResult.Failure3;
        }
        //プレイヤーのカードがSekidouで敵の魔石が緑の時
        if (myCard.HasFlag(PlayerType.Sekidou) && enemyType.HasFlag(EnemyType.Green))
        {
            Debug.Log("Sekidouで攻撃をした");
            return TurnResult.Success3;
        }
        //プレイヤーのカードがSekidouで敵の魔石が赤、青、黄色、紫、金、白の時
        if (myCard.HasFlag(PlayerType.Sekidou) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue)
            || enemyType.HasFlag(EnemyType.Yellow)) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.White))
        {
            Debug.Log("Sekidouで攻撃をしたが失敗");
            return TurnResult.Failure3;
        }
        //プレイヤーのカードがMitoriで敵の魔石が黄色の時
        if (myCard.HasFlag(PlayerType.Mitori) && enemyType.HasFlag(EnemyType.Yellow))
        {
            Debug.Log("Sekidouで攻撃をした");
            return TurnResult.Success3;
        }
        //プレイヤーのカードがMitoriで敵の魔石が赤、青、緑、紫、金、白の時
        if (myCard.HasFlag(PlayerType.Mitori) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue)
            || enemyType.HasFlag(EnemyType.Green)) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.White))
        {
            Debug.Log("Mitoriで攻撃をしたが失敗");
            return TurnResult.Failure3;
        }
        //プレイヤーのカードがSiratoriで敵の魔石が紫の時
        if (myCard.HasFlag(PlayerType.Siratori) && enemyType.HasFlag(EnemyType.Purple))
        {
            Debug.Log("Siratoriで攻撃をした");
            return TurnResult.Success3;
        }
        //プレイヤーのカードがSiratoriで敵の魔石が赤、青、緑、黄色、金、白の時
        if (myCard.HasFlag(PlayerType.Siratori) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue)
            || enemyType.HasFlag(EnemyType.Green)) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.White))
        {
            Debug.Log("Siratoriで攻撃をしたが失敗");
            return TurnResult.Failure3;
        }
        //プレイヤーのカードがGotoudaで敵の魔石が金の時
        if (myCard.HasFlag(PlayerType.Gotouda) && enemyType.HasFlag(EnemyType.Gold))
        {
            Debug.Log("Gotoudaで攻撃をした");
            return TurnResult.Success3;
        }
        //プレイヤーのカードがGotoudaで敵の魔石が赤、青、緑、黄色、紫、白の時
        if (myCard.HasFlag(PlayerType.Gotouda) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue)
            || enemyType.HasFlag(EnemyType.Green)) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.White))
        {
            Debug.Log("Gotoudaで攻撃をしたが失敗");
            return TurnResult.Failure3;
        }
        //プレイヤーのカードがYokosimaで敵の魔石が白の時
        if (myCard.HasFlag(PlayerType.Yokosima) && enemyType.HasFlag(EnemyType.White))
        {
            Debug.Log("Yokosimaで攻撃をした");
            return TurnResult.Success3;
        }
        //プレイヤーのカードがYokosimaで敵の魔石が赤、青、緑、黄色、紫、金の時
        if (myCard.HasFlag(PlayerType.Yokosima) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue)
            || enemyType.HasFlag(EnemyType.Green)) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold))
        {
            Debug.Log("Yokosimaで攻撃をしたが失敗");
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
using UnityEngine;
public class RuleBook : MonoBehaviour
{
    //���ʂ̕\��
    public TurnResult Result(PlayerType player, EnemyType enemy)
    {
        PlayerType myCard = player;
        EnemyType enemyType = enemy;
        //6������Ώ�
        //�v���C���[�̃J�[�h��Yanagi�œG�̖��΂��ԁA�A�΁A���F�A���A���̎��@
        if (myCard.HasFlag(PlayerType.Yanagi) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
           || (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow)) || (enemyType.HasFlag(EnemyType.Purple)) || (enemyType.HasFlag(EnemyType.Gold)))))
        {
            Debug.Log("Yanagi�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h��Yanagi�œG�̖��΂����̎�
        if (myCard.HasFlag(PlayerType.Kizaki) && (enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Yanagi�ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h��Kouga�œG�̖��΂��ԁA�A�΁A���F�A���A���̎��@
        if (myCard.HasFlag(PlayerType.Kouga) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
           || (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow)) || (enemyType.HasFlag(EnemyType.White)) || (enemyType.HasFlag(EnemyType.Gold)))))
        {
            Debug.Log("Kouga�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h��Kouga�œG�̖��΂����̎�
        if (myCard.HasFlag(PlayerType.Kouga) && (enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Kouga�ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h��Genga�œG�̖��΂��ԁA�A�΁A���F�A���A���̎��@
        if (myCard.HasFlag(PlayerType.Genma) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
           || (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow)) || (enemyType.HasFlag(EnemyType.Purple)) || (enemyType.HasFlag(EnemyType.White)))))
        {
            Debug.Log("Genga�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h��Genga�œG�̖��΂����̎�
        if (myCard.HasFlag(PlayerType.Genma) && (enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Genga�ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h��Kizaki�œG�̖��΂��ԁA�A�΁A���A���A���̎��@
        if (myCard.HasFlag(PlayerType.Kizaki) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.White)) || (enemyType.HasFlag(EnemyType.Purple)) || (enemyType.HasFlag(EnemyType.Gold)))))
        {
            Debug.Log("Kizaki�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h��Kizaki�œG�̖��΂����F�̎�
        if (myCard.HasFlag(PlayerType.Kizaki) && (enemyType.HasFlag(EnemyType.Yellow)))
        {
            Debug.Log("Kizaki�ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h��Hasiwaka�œG�̖��΂��ԁA�A���F�A���A���A���̎�
        if (myCard.HasFlag(PlayerType.Hasiwaka) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.White)) || (enemyType.HasFlag(EnemyType.Gold)) || (enemyType.HasFlag(EnemyType.Purple)) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Hasiwaka�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h��Hasiwaka�œG�̖��΂��΂̎�
        if (myCard.HasFlag(PlayerType.Hasiwaka) && (enemyType.HasFlag(EnemyType.Green)))
        {
            Debug.Log("Hasiwaka�ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h��Itadaki�œG�̖��΂��ԁA�΁A���F�A���A���A���̎�
        if (myCard.HasFlag(PlayerType.Itadaki) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.White)) || (enemyType.HasFlag(EnemyType.Gold)) || (enemyType.HasFlag(EnemyType.Purple)) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Itadaki�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h��Itadaki�œG�̖��΂��̎�
        if (myCard.HasFlag(PlayerType.Itadaki) && (enemyType.HasFlag(EnemyType.Blue)))
        {
            Debug.Log("Itadaki�ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h��Nanase�œG�̖��΂��A�΁A���F�A���A���A���̎�
        if (myCard.HasFlag(PlayerType.Nanase) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
           || (enemyType.HasFlag(EnemyType.White)) || (enemyType.HasFlag(EnemyType.Gold)) || (enemyType.HasFlag(EnemyType.Purple)) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Nanase�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h��Nanase�œG�̖��΂��Ԃ̎�
        if (myCard.HasFlag(PlayerType.Nanase) && (enemyType.HasFlag(EnemyType.Red)))
        {
            Debug.Log("Nanase�ōU�������������s");
            return TurnResult.Failure1;
        }
        //4������Ώ�
        //�v���C���[�̃J�[�h��Hyakuti�œG�̖��΂��ԁA�A���A���̎�
        if (myCard.HasFlag(PlayerType.Hyakuti) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue)))
            || (enemyType.HasFlag(EnemyType.Gold)) || (enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Hyakuti�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Hyakuti�œG�̖��΂��΁A���F�A���̎�
        if (myCard.HasFlag(PlayerType.Hyakuti) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.White) || (enemyType.HasFlag(EnemyType.Yellow)))))
        {
            Debug.Log("Hyakuti�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Yaiba�œG�̖��΂��ԁA�A�΁A���F�̎�
        if (myCard.HasFlag(PlayerType.Yaiba) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue)))
            || (enemyType.HasFlag(EnemyType.Yellow)) || (enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Yaiba�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Yaiba�œG�̖��΂����A���A���̎�
        if (myCard.HasFlag(PlayerType.Yaiba) && (enemyType.HasFlag(EnemyType.Yellow) || (enemyType.HasFlag(EnemyType.White) || (enemyType.HasFlag(EnemyType.Gold)))))
        {
            Debug.Log("Yaiba�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Kimata�œG�̖��΂��ԁA�΁A���A���̎�
        if (myCard.HasFlag(PlayerType.Kimata) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Gold)) || (enemyType.HasFlag(EnemyType.Purple)) || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("Kimata�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Kimata�œG�̖��΂��A���F�A���̎�
        if (myCard.HasFlag(PlayerType.Kimata) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow)) || (enemyType.HasFlag(EnemyType.White))))
        {
            Debug.Log("Kimata�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Manami�œG�̖��΂��ԁA�΁A���A�̎�
        if (myCard.HasFlag(PlayerType.Manami) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Gold)) || (enemyType.HasFlag(EnemyType.Blue)) || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("Manami�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Manami�œG�̖��΂����A���F�A���̎�
        if (myCard.HasFlag(PlayerType.Manami) && (enemyType.HasFlag(EnemyType.Purple) || (enemyType.HasFlag(EnemyType.Yellow)) || (enemyType.HasFlag(EnemyType.White))))
        {
            Debug.Log("Manami�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Otogi�œG�̖��΂��ԁA�΁A���A�̎�
        if (myCard.HasFlag(PlayerType.Otogi) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Purple)) || (enemyType.HasFlag(EnemyType.Blue)) || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("Otogi�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Otogi�œG�̖��΂����A���F�A���̎�
        if (myCard.HasFlag(PlayerType.Otogi) && (enemyType.HasFlag(EnemyType.Gold) || (enemyType.HasFlag(EnemyType.Yellow)) || (enemyType.HasFlag(EnemyType.White))))
        {
            Debug.Log("Otogi�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Yuzuki�œG�̖��΂��ԁA���F�A���A���̎�
        if (myCard.HasFlag(PlayerType.Yuzuki) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow)) || (enemyType.HasFlag(EnemyType.Gold)) || (enemyType.HasFlag(EnemyType.Purple))))
        {
            Debug.Log("Yuzuki�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Yuzuki�œG�̖��΂��A�΁A���̎�
        if (myCard.HasFlag(PlayerType.Yuzuki) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.White)) || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("Yuzuki�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Yukime�œG�̖��΂��A�΁A���A���̎�
        if (myCard.HasFlag(PlayerType.Yukime) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))) || (enemyType.HasFlag(EnemyType.Gold)) || (enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Yukime�ōU��������");
            return TurnResult.Success2;
        }
        //  �v���C���[�̃J�[�h��Yukime�œG�̖��΂��ԁA���F�A���̎�
        if (myCard.HasFlag(PlayerType.Yukime) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))) || (enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Yukime�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Inukai�œG�̖��΂��A���F�A���A���̎�
        if (myCard.HasFlag(PlayerType.Inukai) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow)) || (enemyType.HasFlag(EnemyType.Gold)) || (enemyType.HasFlag(EnemyType.Purple))))
        {
            Debug.Log("Inukai�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Inukai�œG�̖��΂��ԁA���F�A���̎�
        if (myCard.HasFlag(PlayerType.Inukai) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow)) || (enemyType.HasFlag(EnemyType.White))))
        {
            Debug.Log("Inukai�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Tennoji�œG�̖��΂��΁A���F�A���A���̎�
        if (myCard.HasFlag(PlayerType.Tennoji) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow)) || (enemyType.HasFlag(EnemyType.Gold)) || (enemyType.HasFlag(EnemyType.Purple))))
        {
            Debug.Log("Tennoji�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Tennoji�œG�̖��΂��ԁA�A���̎�
        if (myCard.HasFlag(PlayerType.Tennoji) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue)) || (enemyType.HasFlag(EnemyType.White))))
        {
            Debug.Log("Tennoji�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Paraberamu�œG�̖��΂��ԁA�A�΁A���̎�
        if (myCard.HasFlag(PlayerType.Paraberamu) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue)) || (enemyType.HasFlag(EnemyType.Green)) || (enemyType.HasFlag(EnemyType.White))))
        {
            Debug.Log("Paraberamu�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Paraberamu�œG�̖��΂����F�A���A���̎�
        if (myCard.HasFlag(PlayerType.Paraberamu) && (enemyType.HasFlag(EnemyType.Yellow) || (enemyType.HasFlag(EnemyType.Purple)) || (enemyType.HasFlag(EnemyType.Gold))))
        {
            Debug.Log("Paraberamu�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Mabosi�œG�̖��΂��ԁA�A���F�A���̎�
        if (myCard.HasFlag(PlayerType.Mabosi) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue)) || (enemyType.HasFlag(EnemyType.Yellow)) || (enemyType.HasFlag(EnemyType.Gold))))
        {
            Debug.Log("Mabosi�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Mabosi�œG�̖��΂��΁A���A���̎�
        if (myCard.HasFlag(PlayerType.Mabosi) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Purple)) || (enemyType.HasFlag(EnemyType.White))))
        {
            Debug.Log("Mabosi�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Sima�œG�̖��΂��ԁA�A���F�A���̎�
        if (myCard.HasFlag(PlayerType.Sima) && enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Purple))
        {
            Debug.Log("Sima�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Sima�œG�̖��΂��΁A���A���̎�
        if (myCard.HasFlag(PlayerType.Sima) && enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.White))
        {
            Debug.Log("Sima�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Yuraki�œG�̖��΂��ԁA�A���F�A���̎�
        if (myCard.HasFlag(PlayerType.Yuraki) && enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.White))
        {
            Debug.Log("Yuraki�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Yuraki�œG�̖��΂��΁A���A���̎�
        if (myCard.HasFlag(PlayerType.Yuraki) && enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Purple))
        {
            Debug.Log("Yuraki�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Risia�œG�̖��΂��Ԃ̎�
        if (myCard.HasFlag(PlayerType.Risia) && (enemyType.HasFlag(EnemyType.Red)))
        {
            Debug.Log("Risia�ōU��������");
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h��Risia�œG�̖��΂��A���F�A�΂̎� 
        if (myCard.HasFlag(PlayerType.Risia) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Risia�ōU�������������s");
            return TurnResult.Failure3;
        }
        //�v���C���[�̃J�[�h��Kurofusi�œG�̖��΂��̎�
        if (myCard.HasFlag(PlayerType.Kurofusi) && (enemyType.HasFlag(EnemyType.Blue)))
        {
            Debug.Log("Kurofusi�ōU��������");
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h��Kurofusi�œG�̖��΂��ԁA���F�A�΂̎� 
        if (myCard.HasFlag(PlayerType.Kurofusi) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Kurofusi�ōU�������������s");
            return TurnResult.Failure3;
        }
        //�v���C���[�̃J�[�h��Kongoji�œG�̖��΂��΂̎�
        if (myCard.HasFlag(PlayerType.Kongoji) && (enemyType.HasFlag(EnemyType.Green)))
        {
            Debug.Log("Kongoji�ōU��������");
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h��Kongoji�œG�̖��΂��ԁA���F�A�̎� 
        if (myCard.HasFlag(PlayerType.Kongoji) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Kongoji�ōU�������������s");
            return TurnResult.Failure3;
        }
        //�v���C���[�̃J�[�h��Yorugami�œG�̖��΂����F�̎�
        if (myCard.HasFlag(PlayerType.Yorugami) && (enemyType.HasFlag(EnemyType.Yellow)))
        {
            Debug.Log("Yorugami�ōU��������");
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�hYorugami�œG�̖��΂��ԁA�΁A�̎� 
        if (myCard.HasFlag(PlayerType.Yorugami) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("Yorugami�ōU�������������s");
            return TurnResult.Failure3;
        }
        //�v���C���[�̃J�[�h��Haisiki�œG�̖��΂��ԁA�A���A���̎�
        if (myCard.HasFlag(PlayerType.Haisiki) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
           || (enemyType.HasFlag(EnemyType.Gold) || (enemyType.HasFlag(EnemyType.White)))))
        {
            Debug.Log("Haisiki�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Haisiki�œG�̖��΂��΁A���F�A���A�̎�
        if (myCard.HasFlag(PlayerType.Haisiki) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))
            || (enemyType.HasFlag(EnemyType.Purple))))
        {
            Debug.Log("Haisiki�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Ryutan�œG�̖��΂��ԁA�A���A���̎�
        if (myCard.HasFlag(PlayerType.Ryutan) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
          || (enemyType.HasFlag(EnemyType.Purple) || (enemyType.HasFlag(EnemyType.White)))))
        {
            Debug.Log("Ryutan�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Ryutan�œG�̖��΂����F�A�΁A���̎�
        if (myCard.HasFlag(PlayerType.Ryutan) && (enemyType.HasFlag(EnemyType.Yellow) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Gold))))
        {
            Debug.Log("Ryutan�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Sekidou�œG�̖��΂��ԁA�΁A���F�A���̎�
        if (myCard.HasFlag(PlayerType.Sekidou) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
          || (enemyType.HasFlag(EnemyType.Yellow) || (enemyType.HasFlag(EnemyType.Gold)))))
        {
            Debug.Log("Sekidou�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Sekidou�œG�̖��΂��A���A���̎�
        if (myCard.HasFlag(PlayerType.Sekidou) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.White))
            || (enemyType.HasFlag(EnemyType.Purple))))
        {
            Debug.Log("Sekidou�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Mitori�œG�̖��΂��ԁA�΁A���F�A���̎�
        if (myCard.HasFlag(PlayerType.Mitori) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
          || (enemyType.HasFlag(EnemyType.Yellow) || (enemyType.HasFlag(EnemyType.Purple)))))
        {
            Debug.Log("Sekidou�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Mitori�œG�̖��΂��A���A���̎�
        if (myCard.HasFlag(PlayerType.Mitori) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.White))
           || (enemyType.HasFlag(EnemyType.Gold))))
        {
            Debug.Log("Mitori�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Siratori�œG�̖��΂��ԁA�΁A���F�A���̎�
        if (myCard.HasFlag(PlayerType.Siratori) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
          || (enemyType.HasFlag(EnemyType.Yellow) || (enemyType.HasFlag(EnemyType.White)))))
        {
            Debug.Log("Siratori�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Siratori�œG�̖��΂��A���A���̎�
        if (myCard.HasFlag(PlayerType.Siratori) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Purple))
          || (enemyType.HasFlag(EnemyType.Gold))))
        {
            Debug.Log("Siratori�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Gotouda�œG�̖��΂��ԁA�΁A���A���̎�
        if (myCard.HasFlag(PlayerType.Gotouda) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
          || (enemyType.HasFlag(EnemyType.Gold) || (enemyType.HasFlag(EnemyType.White)))))
        {
            Debug.Log("Gotouda�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Gotouda�œG�̖��΂��A���F�A���̎�
        if (myCard.HasFlag(PlayerType.Gotouda) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))
         || (enemyType.HasFlag(EnemyType.Purple))))
        {
            Debug.Log("Gotouda�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Yokosima�œG�̖��΂��ԁA�΁A���A���̎�
        if (myCard.HasFlag(PlayerType.Yokosima) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
         || (enemyType.HasFlag(EnemyType.Purple) || (enemyType.HasFlag(EnemyType.White)))))
        {
            Debug.Log("Yokosima�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Yokosima�œG�̖��΂��A���F�A���̎�
        if (myCard.HasFlag(PlayerType.Yokosima) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))
         || (enemyType.HasFlag(EnemyType.Gold))))
        {
            Debug.Log("Yokosima�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Sabitani�œG�̖��΂��ԁA���F�A���A���̎�
        if (myCard.HasFlag(PlayerType.Sabitani) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))
         || (enemyType.HasFlag(EnemyType.Gold) || (enemyType.HasFlag(EnemyType.White)))))
        {
            Debug.Log("Sabitani�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Sabitani�œG�̖��΂��A�΁A���̎�
        if (myCard.HasFlag(PlayerType.Sabitani) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
         || (enemyType.HasFlag(EnemyType.Purple))))
        {
            Debug.Log("Sabitani�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Cuga�œG�̖��΂��ԁA���F�A���A���̎�
        if (myCard.HasFlag(PlayerType.Cuga) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))
        || (enemyType.HasFlag(EnemyType.Purple) || (enemyType.HasFlag(EnemyType.White)))))
        {
            Debug.Log("Cuga�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Cuga�œG�̖��΂��A�΁A���̎�
        if (myCard.HasFlag(PlayerType.Cuga) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
        || (enemyType.HasFlag(EnemyType.Gold))))
        {
            Debug.Log("Cuga�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Nano�œG�̖��΂��A�΁A���F�A���̎�
        if (myCard.HasFlag(PlayerType.Nano) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
       || (enemyType.HasFlag(EnemyType.Yellow) || (enemyType.HasFlag(EnemyType.Gold)))))
        {
            Debug.Log("Nano�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Nano�œG�̖��΂��ԁA���A���̎�
        if (myCard.HasFlag(PlayerType.Nano) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Purple))
       || (enemyType.HasFlag(EnemyType.White))))
        {
            Debug.Log("Nano�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Himeno�œG�̖��΂��A���F�A���A���̎�
        if (myCard.HasFlag(PlayerType.Himeno) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))
       || (enemyType.HasFlag(EnemyType.Purple) || (enemyType.HasFlag(EnemyType.White)))))
        {
            Debug.Log("Himeno�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Himeno�œG�̖��΂��ԁA�΁A���̎�
        if (myCard.HasFlag(PlayerType.Himeno) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
      || (enemyType.HasFlag(EnemyType.Gold))))
        {
            Debug.Log("Himeno�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Miki�œG�̖��΂��A�΁A���F�A���̎�
        if (myCard.HasFlag(PlayerType.Miki) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
       || (enemyType.HasFlag(EnemyType.Yellow) || (enemyType.HasFlag(EnemyType.Purple)))))
        {
            Debug.Log("Miki�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Miki�œG�̖��΂��ԁA���A���̎�
        if (myCard.HasFlag(PlayerType.Miki) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Gold))
      || (enemyType.HasFlag(EnemyType.White))))
        {
            Debug.Log("Miki�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Momoti�œG�̖��΂��A�΁A���F�A���̎�
        if (myCard.HasFlag(PlayerType.Momoti) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
       || (enemyType.HasFlag(EnemyType.Yellow) || (enemyType.HasFlag(EnemyType.White)))))
        {
            Debug.Log("Momoti�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Momoti�œG�̖��΂��ԁA���A���̎�
        if (myCard.HasFlag(PlayerType.Momoti) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Purple))
      || (enemyType.HasFlag(EnemyType.Gold))))
        {
            Debug.Log("Momoti�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Akamatu�œG�̖��΂��A�΁A���A���̎�
        if (myCard.HasFlag(PlayerType.Akamatu) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
       || (enemyType.HasFlag(EnemyType.Gold) || (enemyType.HasFlag(EnemyType.White)))))
        {
            Debug.Log("Akamatu�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Akamatu�œG�̖��΂��ԁA�A���̎�
        if (myCard.HasFlag(PlayerType.Akamatu) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
      || (enemyType.HasFlag(EnemyType.Purple))))
        {
            Debug.Log("Akamatu�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Otuki�œG�̖��΂��A�΁A���A���̎�
        if (myCard.HasFlag(PlayerType.Otuki) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
       || (enemyType.HasFlag(EnemyType.Purple) || (enemyType.HasFlag(EnemyType.White)))))
        {
            Debug.Log("Otuki�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Otuki�œG�̖��΂��ԁA���F�A���̎�
        if (myCard.HasFlag(PlayerType.Otuki) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))
      || (enemyType.HasFlag(EnemyType.Gold))))
        {
            Debug.Log("Otuki�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Kondou�œG�̖��΂��A���F�A���A���̎�
        if (myCard.HasFlag(PlayerType.Kondou) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))
       || (enemyType.HasFlag(EnemyType.Gold) || (enemyType.HasFlag(EnemyType.White)))))
        {
            Debug.Log("Kondou�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Kondou�œG�̖��΂��ԁA�΁A���̎�
        if (myCard.HasFlag(PlayerType.Kondou) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
     || (enemyType.HasFlag(EnemyType.Purple))))
        {
            Debug.Log("Kondou�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Jyack�œG�̖��΂��΁A���F�A���A���̎�
        if (myCard.HasFlag(PlayerType.Jyack) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))
       || (enemyType.HasFlag(EnemyType.Gold) || (enemyType.HasFlag(EnemyType.White)))))
        {
            Debug.Log("Jyack�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Jyack�œG�̖��΂��ԁA�A���̎�
        if (myCard.HasFlag(PlayerType.Jyack) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
    || (enemyType.HasFlag(EnemyType.Purple))))
        {
            Debug.Log("Jyack�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Jyozetu�œG�̖��΂��΁A���F�A���A���̎�
        if (myCard.HasFlag(PlayerType.Jyozetu) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))
      || (enemyType.HasFlag(EnemyType.Gold) || (enemyType.HasFlag(EnemyType.White)))))
        {
            Debug.Log("Jyozetu�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Jyozetu�œG�̖��΂��ԁA�A���̎�
        if (myCard.HasFlag(PlayerType.Jyozetu) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
   || (enemyType.HasFlag(EnemyType.Purple))))
        {
            Debug.Log("Jyozetu�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Tuzimura�œG�̖��΂����F�A���A���A���̎�
        if (myCard.HasFlag(PlayerType.Tuzimura) && (enemyType.HasFlag(EnemyType.Yellow) || (enemyType.HasFlag(EnemyType.Gold))
      || (enemyType.HasFlag(EnemyType.Purple) || (enemyType.HasFlag(EnemyType.White)))))
        {
            Debug.Log("Tuzimura�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Tuzimura�œG�̖��΂��ԁA�A�΂̎�
        if (myCard.HasFlag(PlayerType.Tuzimura) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
  || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("Tuzimura�ōU�������������s");
            return TurnResult.Failure2;
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
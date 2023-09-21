using UnityEngine;
public class RuleBook : MonoBehaviour
{
    //���ʂ̕\��
    public TurnResult Result(PlayerType player, EnemyType enemy)
    {
        PlayerType myCard = player;
        EnemyType enemyType = enemy;
        //4������Ώ�
        //�v���C���[�̃J�[�h��Yanagi�œG�̖��΂��A�΁A���A���̎�
        if (myCard.HasFlag(PlayerType.Yanagi) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green)
           || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Yanagi�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h��Yanagi�œG�̖��΂��ԁA���F�A���̎�
        if (myCard.HasFlag(PlayerType.Yanagi) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Yanagi�ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h��Kouga�œG�̖��΂����F�A���A���A�Ԃ̎��@
        if (myCard.HasFlag(PlayerType.Kouga) && (enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.White) || enemyType.HasFlag(EnemyType.Red)))
        {
            Debug.Log("Kouga�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h��Kouga�œG�̖��΂��A�΁A���̎�
        if (myCard.HasFlag(PlayerType.Kouga) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Kouga�ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h��Genga�œG�̖��΂����A�ԁA���A�΂̎��@
        if (myCard.HasFlag(PlayerType.Genma) && (enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Green)))
        {
            Debug.Log("Genma�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h��Genga�œG�̖��΂��A���F�A���̎�
        if (myCard.HasFlag(PlayerType.Genma) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Genma�ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h��Kizaki�œG�̖��΂����A���A���A�̎��@
        if (myCard.HasFlag(PlayerType.Kizaki) && (enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.White) || enemyType.HasFlag(EnemyType.Blue)))
        {
            Debug.Log("Kizaki�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h��Kizaki�œG�̖��΂��ԁA���F�A�΂̎�
        if (myCard.HasFlag(PlayerType.Kizaki) && enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Green))
        {
            Debug.Log("Kizaki�ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h��Hasiwaka�œG�̖��΂��ԁA�΁A���F�A���̎�
        if (myCard.HasFlag(PlayerType.Hasiwaka) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Hasiwaka�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h��Hasiwaka�œG�̖��΂��A���A���̎�
        if (myCard.HasFlag(PlayerType.Hasiwaka) && enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.White))
        {
            Debug.Log("Hasiwaka�ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h��Itadaki�œG�̖��΂��A�΁A���A���̎�
        if (myCard.HasFlag(PlayerType.Itadaki) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Itadaki�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h��Itadaki�œG�̖��΂��ԁA���F�A���̎�
        if (myCard.HasFlag(PlayerType.Itadaki) && enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.White))
        {
            Debug.Log("Itadaki�ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h��Nanase�œG�̖��΂����A���A���F�A�Ԃ̎�
        if (myCard.HasFlag(PlayerType.Nanase) && (enemyType.HasFlag(EnemyType.White) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Red)))
        {
            Debug.Log("Nanase�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h��Nanase�œG�̖��΂��A�΁A���̎�
        if (myCard.HasFlag(PlayerType.Nanase) && enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Gold))
        {
            Debug.Log("Nanase�ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h��Hyakuti�œG�̖��΂��΁A���A�ԁA�̎�
        if (myCard.HasFlag(PlayerType.Hyakuti) && (enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue)))
        {
            Debug.Log("Hyakuti�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h��Hyakuti�œG�̖��΂����A���F�A���̎�
        if (myCard.HasFlag(PlayerType.Hyakuti) && (enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Hyakuti�ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h��Yaiba�œG�̖��΂��ԁA���F�A���A���̎�
        if (myCard.HasFlag(PlayerType.Yaiba) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Yaiba�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h��Yaiba�œG�̖��΂��A�΁A���̎�
        if (myCard.HasFlag(PlayerType.Yaiba) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Yaiba�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Kimata�œG�̖��΂��A���A���A���F�̎�
        if (myCard.HasFlag(PlayerType.Kimata) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Yellow)))
        {
            Debug.Log("Kimata�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h��Kimata�œG�̖��΂��A���F�A���̎�
        if (myCard.HasFlag(PlayerType.Kimata) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Kimata�ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h��Manami�œG�̖��΂��΁A���A�A���̎�
        if (myCard.HasFlag(PlayerType.Manami) && (enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Manami�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h��Manami�œG�̖��΂��ԁA���F�A���̎�
        if (myCard.HasFlag(PlayerType.Manami) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Manami�ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h��Otogi�œG�̖��΂����F�A���A�ԁA�΂̎�
        if (myCard.HasFlag(PlayerType.Otogi) && (enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.White) || enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Green)))
        {
            Debug.Log("Otogi�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h��Otogi�œG�̖��΂��A���A���̎�
        if (myCard.HasFlag(PlayerType.Otogi) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Otogi�ōU�������������s");
            return TurnResult.Failure1;
        }

        //3������Ώ�
        //�v���C���[�̃J�[�h��Yuzuki�œG�̖��΂��ԁA�A�΂̎�
        if (myCard.HasFlag(PlayerType.Yuzuki) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green)))
        {
            Debug.Log("Yuzuki�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Yuzuki�œG�̖��΂����F�A���A��,�A���̎�
        if (myCard.HasFlag(PlayerType.Yuzuki) && (enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.White) || enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Yuzuki�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Yukime�œG�̖��΂����F�A���A���̎�
        if (myCard.HasFlag(PlayerType.Yukime) && (enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Yukime�ōU��������");
            return TurnResult.Success2;
        }
        //  �v���C���[�̃J�[�h��Yukime�œG�̖��΂��ԁA�A�΁A���̎�
        if (myCard.HasFlag(PlayerType.Yukime) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Yukime�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Inukai�œG�̖��΂����A�ԁA���̎�
        if (myCard.HasFlag(PlayerType.Inukai) && (enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Inukai�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Inukai�œG�̖��΂��A���F�A�΁A���̎�
        if (myCard.HasFlag(PlayerType.Yukime) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Inukai�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Tennoji�œG�̖��΂����A���A���̎�
        if (myCard.HasFlag(PlayerType.Tennoji) && (enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Tennoji�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Tennoji�œG�̖��΂��ԁA�A���F�A�΂̎�
        if (myCard.HasFlag(PlayerType.Tennoji) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Green)))
        {
            Debug.Log("Tennoji�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Paraberamu�œG�̖��΂��A�΁A���̎�
        if (myCard.HasFlag(PlayerType.Paraberamu) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Paraberamu�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Paraberamu�œG�̖��΂��ԁA���F�A���A���̎�
        if (myCard.HasFlag(PlayerType.Paraberamu) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Paraberamu�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Mabosi�œG�̖��΂����F�A�΁A���̎�
        if (myCard.HasFlag(PlayerType.Mabosi) && (enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Mabosi�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Mabosi�œG�̖��΂��ԁA�A���A���̎�
        if (myCard.HasFlag(PlayerType.Mabosi) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.White) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Mabosi�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Sima�œG�̖��΂��ԁA���F�A���̎�
        if (myCard.HasFlag(PlayerType.Sima) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Sima�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Sima�œG�̖��΂��΁A�A���A���̎�
        if (myCard.HasFlag(PlayerType.Sima) && (enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Sima�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Yuraki�œG�̖��΂��A���A���̎�
        if (myCard.HasFlag(PlayerType.Yuraki) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Yuraki�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Yuraki�œG�̖��΂��ԁA�΁A���A���̎�
        if (myCard.HasFlag(PlayerType.Yuraki) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.White) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Yuraki�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Risia�œG�̖��΂��΁A���F�A���̎�
        if (myCard.HasFlag(PlayerType.Risia) && (enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Risia�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Risia�œG�̖��΂��ԁA�A���A���̎� 
        if (myCard.HasFlag(PlayerType.Risia) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Risia�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Kurofusi�œG�̖��΂��ԁA���F�A���̎�
        if (myCard.HasFlag(PlayerType.Kurofusi) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Kurofusi�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Kurofusi�œG�̖��΂��A�΁A���A���̎� 
        if (myCard.HasFlag(PlayerType.Kurofusi) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.White) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Kurofusi�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Kongoji�œG�̖��΂��A�΁A���̎�
        if (myCard.HasFlag(PlayerType.Kongoji) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.White)))
        {
            Debug.Log("Kongoji�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Kongoji�œG�̖��΂��ԁA���F�A���A���̎� 
        if (myCard.HasFlag(PlayerType.Kongoji) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Kongoji�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Yorugami�œG�̖��΂��ԁA���F�A���̎�
        if (myCard.HasFlag(PlayerType.Yorugami) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Purple)))
        {
            Debug.Log("Yorugami�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�hYorugami�œG�̖��΂��A�΁A���A���̎� 
        if (myCard.HasFlag(PlayerType.Yorugami) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.White) || enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Yorugami�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Sabitani�œG�̖��΂��ԁA�A���F�̎�
        if (myCard.HasFlag(PlayerType.Sabitani) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue)
         || enemyType.HasFlag(EnemyType.Yellow)))
        {
            Debug.Log("Sabitani�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Sabitani�œG�̖��΂��΁A���A���A���̎�
        if (myCard.HasFlag(PlayerType.Sabitani) && (enemyType.HasFlag(EnemyType.Green) || enemyType.HasFlag(EnemyType.White)
         || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold)))
        {
            Debug.Log("Sabitani�ōU�������������s");
            return TurnResult.Failure2;
        }

        //1������Ώ�
        //�v���C���[�̃J�[�h��Haisiki�œG�̖��΂��Ԃ̎�
        if (myCard.HasFlag(PlayerType.Haisiki) && enemyType.HasFlag(EnemyType.Red))
        {
            Debug.Log("Haisiki�ōU��������");
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h��Haisiki�œG�̖��΂��A�΁A���F�A���A���A���̎�
        if (myCard.HasFlag(PlayerType.Haisiki) && (enemyType.HasFlag(EnemyType.Blue) || enemyType.HasFlag(EnemyType.Green)
            || enemyType.HasFlag(EnemyType.Yellow)) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.White))
        {
            Debug.Log("Haisiki�ōU�������������s");
            return TurnResult.Failure3;
        }
        //�v���C���[�̃J�[�h��Ryutan�œG�̖��΂��̎�
        if (myCard.HasFlag(PlayerType.Ryutan) && enemyType.HasFlag(EnemyType.Blue))
        {
            Debug.Log("Ryutan�ōU��������");
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h��Ryutan�œG�̖��΂��ԁA�΁A���F�A���A���A���̎�
        if (myCard.HasFlag(PlayerType.Ryutan) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Green)
            || enemyType.HasFlag(EnemyType.Yellow)) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.White))
        {
            Debug.Log("Ryutan�ōU�������������s");
            return TurnResult.Failure3;
        }
        //�v���C���[�̃J�[�h��Sekidou�œG�̖��΂��΂̎�
        if (myCard.HasFlag(PlayerType.Sekidou) && enemyType.HasFlag(EnemyType.Green))
        {
            Debug.Log("Sekidou�ōU��������");
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h��Sekidou�œG�̖��΂��ԁA�A���F�A���A���A���̎�
        if (myCard.HasFlag(PlayerType.Sekidou) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue)
            || enemyType.HasFlag(EnemyType.Yellow)) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.White))
        {
            Debug.Log("Sekidou�ōU�������������s");
            return TurnResult.Failure3;
        }
        //�v���C���[�̃J�[�h��Mitori�œG�̖��΂����F�̎�
        if (myCard.HasFlag(PlayerType.Mitori) && enemyType.HasFlag(EnemyType.Yellow))
        {
            Debug.Log("Sekidou�ōU��������");
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h��Mitori�œG�̖��΂��ԁA�A�΁A���A���A���̎�
        if (myCard.HasFlag(PlayerType.Mitori) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue)
            || enemyType.HasFlag(EnemyType.Green)) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.White))
        {
            Debug.Log("Mitori�ōU�������������s");
            return TurnResult.Failure3;
        }
        //�v���C���[�̃J�[�h��Siratori�œG�̖��΂����̎�
        if (myCard.HasFlag(PlayerType.Siratori) && enemyType.HasFlag(EnemyType.Purple))
        {
            Debug.Log("Siratori�ōU��������");
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h��Siratori�œG�̖��΂��ԁA�A�΁A���F�A���A���̎�
        if (myCard.HasFlag(PlayerType.Siratori) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue)
            || enemyType.HasFlag(EnemyType.Green)) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Gold) || enemyType.HasFlag(EnemyType.White))
        {
            Debug.Log("Siratori�ōU�������������s");
            return TurnResult.Failure3;
        }
        //�v���C���[�̃J�[�h��Gotouda�œG�̖��΂����̎�
        if (myCard.HasFlag(PlayerType.Gotouda) && enemyType.HasFlag(EnemyType.Gold))
        {
            Debug.Log("Gotouda�ōU��������");
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h��Gotouda�œG�̖��΂��ԁA�A�΁A���F�A���A���̎�
        if (myCard.HasFlag(PlayerType.Gotouda) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue)
            || enemyType.HasFlag(EnemyType.Green)) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.White))
        {
            Debug.Log("Gotouda�ōU�������������s");
            return TurnResult.Failure3;
        }
        //�v���C���[�̃J�[�h��Yokosima�œG�̖��΂����̎�
        if (myCard.HasFlag(PlayerType.Yokosima) && enemyType.HasFlag(EnemyType.White))
        {
            Debug.Log("Yokosima�ōU��������");
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h��Yokosima�œG�̖��΂��ԁA�A�΁A���F�A���A���̎�
        if (myCard.HasFlag(PlayerType.Yokosima) && (enemyType.HasFlag(EnemyType.Red) || enemyType.HasFlag(EnemyType.Blue)
            || enemyType.HasFlag(EnemyType.Green)) || enemyType.HasFlag(EnemyType.Yellow) || enemyType.HasFlag(EnemyType.Purple) || enemyType.HasFlag(EnemyType.Gold))
        {
            Debug.Log("Yokosima�ōU�������������s");
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
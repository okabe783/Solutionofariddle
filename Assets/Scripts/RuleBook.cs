using UnityEngine;
public class RuleBook : MonoBehaviour
{
    //���ʂ̕\��
    public TurnResult Result(Player _player, Enemy _enemy)
    {
        PlayerType myCard = PlayerType.None;
        EnemyType enemyType = EnemyType.None;
        // �J�[�h�̕]�����s��
        //�v���C���[�̃J�[�h��Kizaki�œG�̖��΂��ԁA�A�΂̎�
        if (myCard.HasFlag(PlayerType.Kizaki) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Green))))
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
        //�v���C���[�̃J�[�h��Hasiwaka�œG�̖��΂��ԁA�A���F�̎�
        if (myCard.HasFlag(PlayerType.Hasiwaka) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Yellow))))
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
        //�v���C���[�̃J�[�h��Itadaki�œG�̖��΂��ԁA�΁A���F�̎�
        if (myCard.HasFlag(PlayerType.Itadaki) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
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
        //�v���C���[�̃J�[�h��Nanase�œG�̖��΂��A�΁A���F�̎�
        if (myCard.HasFlag(PlayerType.Nanase) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
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
        //�v���C���[�̃J�[�h��Hyakuti�œG�̖��΂��ԁA�̎�
        if (myCard.HasFlag(PlayerType.Hyakuti) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))))
        {
            Debug.Log("Hyakuti�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Hyakuti�œG�̖��΂��΁A���F�̎�
        if (myCard.HasFlag(PlayerType.Hyakuti) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Hyakuti�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Kimata�œG�̖��΂��ԁA�΂̎�
        if (myCard.HasFlag(PlayerType.Kimata) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("Kimata�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Kimata�œG�̖��΂��A���F�̎�
        if (myCard.HasFlag(PlayerType.Kimata) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Kimata�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Yuzuki�œG�̖��΂��ԁA���F�̎�
        if (myCard.HasFlag(PlayerType.Yuzuki) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Yuzuki�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Yuzuki�œG�̖��΂��A�΂̎�
        if (myCard.HasFlag(PlayerType.Yuzuki) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("Yuzuki�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Yukime�œG�̖��΂��A�΂̎�
        if (myCard.HasFlag(PlayerType.Yukime) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("Yukime�ōU��������");
            return TurnResult.Success2;
        }
        //  �v���C���[�̃J�[�h��Yukime�œG�̖��΂��ԁA���F�̎�
        if (myCard.HasFlag(PlayerType.Yukime) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Yukime�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Inukai�œG�̖��΂��A���F�̎�
        if (myCard.HasFlag(PlayerType.Inukai) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Inukai�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Inukai�œG�̖��΂��ԁA���F�̎�
        if (myCard.HasFlag(PlayerType.Inukai) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Inukai�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h��Tennoji�œG�̖��΂��΁A���F�̎�
        if (myCard.HasFlag(PlayerType.Tennoji) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("Tennoji�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h��Tennoji�œG�̖��΂��ԁA�̎�
        if (myCard.HasFlag(PlayerType.Tennoji) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))))
        {
            Debug.Log("Tennoji�ōU�������������s");
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
        Debug.Log("���������͂�΂Ȃ��ł�������");
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
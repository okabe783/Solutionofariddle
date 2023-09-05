using UnityEngine;
public class RuleBook : MonoBehaviour
{
    //���ʂ̕\��
    public TurnResult Result(Player _player, Enemy _enemy)
    {
        PlayerType myCard = PlayerType.None;
        EnemyType enemyType = EnemyType.None;
        // �J�[�h�̕]�����s��
        //�v���C���[�̃J�[�h�����œG�̖��΂��ԁA�A�΂̎�
        if (myCard.HasFlag(PlayerType.Kizaki) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("���ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂����F�̎�
        if (myCard.HasFlag(PlayerType.Kizaki) && (enemyType.HasFlag(EnemyType.Yellow)))
        {
            Debug.Log("���ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��ԁA�A���F�̎�
        if (myCard.HasFlag(PlayerType.Hasiwaka) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("���ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��΂̎�
        if (myCard.HasFlag(PlayerType.Hasiwaka) && (enemyType.HasFlag(EnemyType.Green)))
        {
            Debug.Log("���ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��ԁA�΁A���F�̎�
        if (myCard.HasFlag(PlayerType.Itadaki) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("���ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��̎�
        if (myCard.HasFlag(PlayerType.Itadaki) && (enemyType.HasFlag(EnemyType.Blue)))
        {
            Debug.Log("���ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h���|�œG�̖��΂��A�΁A���F�̎�
        if (myCard.HasFlag(PlayerType.Nanase) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("�|�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h���|�œG�̖��΂��Ԃ̎�
        if (myCard.HasFlag(PlayerType.Nanase) && (enemyType.HasFlag(EnemyType.Red)))
        {
            Debug.Log("�|�ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h���e�œG�̖��΂��ԁA�̎�
        if (myCard.HasFlag(PlayerType.Hyakuti) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))))
        {
            Debug.Log("�e�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h���e�œG�̖��΂��΁A���F�̎�
        if (myCard.HasFlag(PlayerType.Hyakuti) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("�e�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��ԁA�΂̎�
        if (myCard.HasFlag(PlayerType.Kimata) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("���ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��A���F�̎�
        if (myCard.HasFlag(PlayerType.Kimata) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("���ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h���񕜂œG�̖��΂��ԁA���F�̎�
        if (myCard.HasFlag(PlayerType.Yuzuki) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("�񕜂ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h���񕜂œG�̖��΂��A�΂̎�
        if (myCard.HasFlag(PlayerType.Yuzuki) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("�񕜂ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h���K�E�Z�œG�̖��΂��A�΂̎�
        if (myCard.HasFlag(PlayerType.Yukime) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("�K�E�Z�ōU��������");
            return TurnResult.Success2;
        }
        //  �v���C���[�̃J�[�h���K�E�Z�œG�̖��΂��ԁA���F�̎�
        if (myCard.HasFlag(PlayerType.Yukime) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("�K�E�Z�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h���藠���œG�̖��΂��A���F�̎�
        if (myCard.HasFlag(PlayerType.Inukai) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("�藠���ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h���藠���œG�̖��΂��ԁA���F�̎�
        if (myCard.HasFlag(PlayerType.Inukai) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("�藠���ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��΁A���F�̎�
        if (myCard.HasFlag(PlayerType.Tennoji) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("���ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��ԁA�̎�
        if (myCard.HasFlag(PlayerType.Tennoji) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))))
        {
            Debug.Log("���ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h����œG�̖��΂��Ԃ̎�
        if (myCard.HasFlag(PlayerType.Risia) && (enemyType.HasFlag(EnemyType.Red)))
        {
            Debug.Log("��ōU��������");
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h����œG�̖��΂��A���F�A�΂̎� 
        if (myCard.HasFlag(PlayerType.Risia) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("��ōU�������������s");
            return TurnResult.Failure3;
        }
        //�v���C���[�̃J�[�h���}�V���K���œG�̖��΂��̎�
        if (myCard.HasFlag(PlayerType.Kurofusi) && (enemyType.HasFlag(EnemyType.Blue)))
        {
            Debug.Log("�}�V���K���ōU��������");
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h���}�V���K���œG�̖��΂��ԁA���F�A�΂̎� 
        if (myCard.HasFlag(PlayerType.Kurofusi) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("�}�V���K���ōU�������������s");
            return TurnResult.Failure3;
        }
        //�v���C���[�̃J�[�h�����e�œG�̖��΂��΂̎�
        if (myCard.HasFlag(PlayerType.Kongoji) && (enemyType.HasFlag(EnemyType.Green)))
        {
            Debug.Log("���e�ōU��������");
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h�����e�œG�̖��΂��ԁA���F�A�̎� 
        if (myCard.HasFlag(PlayerType.Kongoji) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("���e�ōU�������������s");
            return TurnResult.Failure3;
        }
        //�v���C���[�̃J�[�h���劙�œG�̖��΂����F�̎�
        if (myCard.HasFlag(PlayerType.Yorugami) && (enemyType.HasFlag(EnemyType.Yellow)))
        {
            Debug.Log("�劙�ōU��������");
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h�劙�œG�̖��΂��ԁA�΁A�̎� 
        if (myCard.HasFlag(PlayerType.Yorugami) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("�劙�ōU�������������s");
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
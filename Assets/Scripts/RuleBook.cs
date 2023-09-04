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
        if (myCard.HasFlag(PlayerType.Sword) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("���ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂����F�̎�
        if (myCard.HasFlag(PlayerType.Sword) && (enemyType.HasFlag(EnemyType.Yellow)))
        {
            Debug.Log("���ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��ԁA�A���F�̎�
        if (myCard.HasFlag(PlayerType.Shield) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("���ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��΂̎�
        if (myCard.HasFlag(PlayerType.Shield) && (enemyType.HasFlag(EnemyType.Green)))
        {
            Debug.Log("���ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��ԁA�΁A���F�̎�
        if (myCard.HasFlag(PlayerType.Spear) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("���ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��̎�
        if (myCard.HasFlag(PlayerType.Spear) && (enemyType.HasFlag(EnemyType.Blue)))
        {
            Debug.Log("���ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h���|�œG�̖��΂��A�΁A���F�̎�
        if (myCard.HasFlag(PlayerType.Bow) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("�|�ōU��������");
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h���|�œG�̖��΂��Ԃ̎�
        if (myCard.HasFlag(PlayerType.Bow) && (enemyType.HasFlag(EnemyType.Red)))
        {
            Debug.Log("�|�ōU�������������s");
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h���e�œG�̖��΂��ԁA�̎�
        if (myCard.HasFlag(PlayerType.Gun) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))))
        {
            Debug.Log("�e�ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h���e�œG�̖��΂��΁A���F�̎�
        if (myCard.HasFlag(PlayerType.Gun) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("�e�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��ԁA�΂̎�
        if (myCard.HasFlag(PlayerType.Fist) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("���ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��A���F�̎�
        if (myCard.HasFlag(PlayerType.Fist) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("���ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h���񕜂œG�̖��΂��ԁA���F�̎�
        if (myCard.HasFlag(PlayerType.Heal) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("�񕜂ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h���񕜂œG�̖��΂��A�΂̎�
        if (myCard.HasFlag(PlayerType.Heal) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("�񕜂ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h���K�E�Z�œG�̖��΂��A�΂̎�
        if (myCard.HasFlag(PlayerType.Special) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))))
        {
            Debug.Log("�K�E�Z�ōU��������");
            return TurnResult.Success2;
        }
        //  �v���C���[�̃J�[�h���K�E�Z�œG�̖��΂��ԁA���F�̎�
        if (myCard.HasFlag(PlayerType.Special) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("�K�E�Z�ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h���藠���œG�̖��΂��A���F�̎�
        if (myCard.HasFlag(PlayerType.Shuriken) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("�藠���ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h���藠���œG�̖��΂��ԁA���F�̎�
        if (myCard.HasFlag(PlayerType.Shuriken) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("�藠���ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��΁A���F�̎�
        if (myCard.HasFlag(PlayerType.Axe) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("���ōU��������");
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��ԁA�̎�
        if (myCard.HasFlag(PlayerType.Axe) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))))
        {
            Debug.Log("���ōU�������������s");
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h����œG�̖��΂��Ԃ̎�
        if (myCard.HasFlag(PlayerType.Staff) && (enemyType.HasFlag(EnemyType.Red)))
        {
            Debug.Log("��ōU��������");
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h����œG�̖��΂��A���F�A�΂̎� 
        if (myCard.HasFlag(PlayerType.Staff) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("��ōU�������������s");
            return TurnResult.Failure3;
        }
        //�v���C���[�̃J�[�h���}�V���K���œG�̖��΂��̎�
        if (myCard.HasFlag(PlayerType.Machinegun) && (enemyType.HasFlag(EnemyType.Blue)))
        {
            Debug.Log("�}�V���K���ōU��������");
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h���}�V���K���œG�̖��΂��ԁA���F�A�΂̎� 
        if (myCard.HasFlag(PlayerType.Machinegun) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("�}�V���K���ōU�������������s");
            return TurnResult.Failure3;
        }
        //�v���C���[�̃J�[�h�����e�œG�̖��΂��΂̎�
        if (myCard.HasFlag(PlayerType.Bomb) && (enemyType.HasFlag(EnemyType.Green)))
        {
            Debug.Log("���e�ōU��������");
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h�����e�œG�̖��΂��ԁA���F�A�̎� 
        if (myCard.HasFlag(PlayerType.Bomb) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            Debug.Log("���e�ōU�������������s");
            return TurnResult.Failure3;
        }
        //�v���C���[�̃J�[�h���劙�œG�̖��΂����F�̎�
        if (myCard.HasFlag(PlayerType.Scythe) && (enemyType.HasFlag(EnemyType.Yellow)))
        {
            Debug.Log("�劙�ōU��������");
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h�劙�œG�̖��΂��ԁA�΁A�̎� 
        if (myCard.HasFlag(PlayerType.Scythe) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
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
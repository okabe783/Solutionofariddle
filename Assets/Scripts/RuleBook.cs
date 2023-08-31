using UnityEngine;
public class RuleBook : MonoBehaviour
{
    //���ʂ̕\��
    public TurnResult Result(Player _player, Enemy _enemy)
    {
        CardType myCard = CardType.None;
        EnemyType enemyType = EnemyType.None;

        // �J�[�h�̕]�����s��
        //�v���C���[�̃J�[�h�����œG�̖��΂��ԁA�A�΂̎�
        if (myCard.HasFlag(CardType.Sword) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Green))))
        {
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂����F�̎�
        if (myCard.HasFlag(CardType.Sword) && (enemyType.HasFlag(EnemyType.Yellow)))
        {
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��ԁA�A���F�̎�
        if (myCard.HasFlag(CardType.Shield) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��΂̎�
        if (myCard.HasFlag(CardType.Shield) && (enemyType.HasFlag(EnemyType.Green)))
        {
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��ԁA�΁A���F�̎�
        if (myCard.HasFlag(CardType.Spear) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��̎�
        if (myCard.HasFlag(CardType.Spear) && (enemyType.HasFlag(EnemyType.Blue)))
        {
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h���|�œG�̖��΂��A�΁A���F�̎�
        if (myCard.HasFlag(CardType.Bow) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Success1;
        }
        //�v���C���[�̃J�[�h���|�œG�̖��΂��Ԃ̎�
        if (myCard.HasFlag(CardType.Bow) && (enemyType.HasFlag(EnemyType.Red)))
        {
            return TurnResult.Failure1;
        }
        //�v���C���[�̃J�[�h���e�œG�̖��΂��ԁA�̎�
        if (myCard.HasFlag(CardType.Gun) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))))
        {
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h���e�œG�̖��΂��΁A���F�̎�
        if (myCard.HasFlag(CardType.Gun) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��ԁA�΂̎�
        if (myCard.HasFlag(CardType.Fist) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))))
        {
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��A���F�̎�
        if (myCard.HasFlag(CardType.Fist) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h���񕜂œG�̖��΂��ԁA���F�̎�
        if (myCard.HasFlag(CardType.Heal) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h���񕜂œG�̖��΂��A�΂̎�
        if (myCard.HasFlag(CardType.Heal) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))))
        {
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h���K�E�Z�œG�̖��΂��A�΂̎�
        if (myCard.HasFlag(CardType.Special) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))))
        {
            return TurnResult.Success2;
        }
        //  �v���C���[�̃J�[�h���K�E�Z�œG�̖��΂��ԁA���F�̎�
        if (myCard.HasFlag(CardType.Special) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h���藠���œG�̖��΂��A���F�̎�
        if (myCard.HasFlag(CardType.Shuriken) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h���藠���œG�̖��΂��ԁA���F�̎�
        if (myCard.HasFlag(CardType.Shuriken) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��΁A���F�̎�
        if (myCard.HasFlag(CardType.Axe) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Success2;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��ԁA�̎�
        if (myCard.HasFlag(CardType.Shuriken) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))))
        {
            return TurnResult.Failure2;
        }
        //�v���C���[�̃J�[�h����œG�̖��΂��Ԃ̎�
        if (myCard.HasFlag(CardType.Staff) && (enemyType.HasFlag(EnemyType.Red)))
        {
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h����œG�̖��΂��A���F�A�΂̎� 
        if (myCard.HasFlag(CardType.Staff) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Failure3;
        }
        //�v���C���[�̃J�[�h���}�V���K���œG�̖��΂��̎�
        if (myCard.HasFlag(CardType.Machinegun) && (enemyType.HasFlag(EnemyType.Blue)))
        {
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h���}�V���K���œG�̖��΂��ԁA���F�A�΂̎� 
        if (myCard.HasFlag(CardType.Staff) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Failure3;
        }
        //�v���C���[�̃J�[�h�����e�œG�̖��΂��΂̎�
        if (myCard.HasFlag(CardType.Bomb) && (enemyType.HasFlag(EnemyType.Green)))
        {
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h���}�V���K���œG�̖��΂��ԁA���F�A�̎� 
        if (myCard.HasFlag(CardType.Bomb) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            return TurnResult.Failure3;
        }
        //�v���C���[�̃J�[�h���劙�œG�̖��΂����F�̎�
        if (myCard.HasFlag(CardType.Scythe) && (enemyType.HasFlag(EnemyType.Yellow)))
        {
            return TurnResult.Success3;
        }
        //�v���C���[�̃J�[�h���}�V���K���œG�̖��΂��ԁA�΁A�̎� 
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
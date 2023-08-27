using System;
using UnityEngine;
public class RuleBook : MonoBehaviour
{
    //���ʂ̕\��
    public void Result(Player _player, Enemy _enemy)
    {
        CardType myCard = CardType.None;
        EnemyType enemyType = EnemyType.None;

        // �J�[�h�̕]�����s��
        //�v���C���[�̃J�[�h�����œG�̖��΂��ԁA�A�΂̎�
        if (myCard.HasFlag(CardType.Sword) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Green))))
        {
            _enemy.Life -= 1;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂����F�̎�
        if (myCard.HasFlag(CardType.Sword) && (enemyType.HasFlag(EnemyType.Yellow)))
        {
            _player.Life -= 1;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��ԁA�A���F�̎�
        if (myCard.HasFlag(CardType.Shield) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _enemy.Life -= 1;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��΂̎�
        if (myCard.HasFlag(CardType.Shield) && (enemyType.HasFlag(EnemyType.Green)))
        {
            _player.Life -= 1;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��ԁA�΁A���F�̎�
        if (myCard.HasFlag(CardType.Spear) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _enemy.Life -= 1;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��̎�
        if (myCard.HasFlag(CardType.Spear) && (enemyType.HasFlag(EnemyType.Blue)))
        {
            _player.Life -= 1;
        }
        //�v���C���[�̃J�[�h���|�œG�̖��΂��A�΁A���F�̎�
        if (myCard.HasFlag(CardType.Bow) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _enemy.Life -= 1;
        }
        //�v���C���[�̃J�[�h���|�œG�̖��΂��Ԃ̎�
        if (myCard.HasFlag(CardType.Bow) && (enemyType.HasFlag(EnemyType.Red)))
        {
            _player.Life -= 1;
        }
        //�v���C���[�̃J�[�h���e�œG�̖��΂��ԁA�̎�
        if (myCard.HasFlag(CardType.Gun) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))))
        {
            _enemy.Life -= 2;
        }
        //�v���C���[�̃J�[�h���e�œG�̖��΂��΁A���F�̎�
        if (myCard.HasFlag(CardType.Gun) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _player.Life -= 2;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��ԁA�΂̎�
        if (myCard.HasFlag(CardType.Fist) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))))
        {
            _enemy.Life -= 2;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��A���F�̎�
        if (myCard.HasFlag(CardType.Fist) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _player.Life -= 2;
        }
        //�v���C���[�̃J�[�h���񕜂œG�̖��΂��ԁA���F�̎�
        if (myCard.HasFlag(CardType.Heal) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _enemy.Life -= 2;
        }
        //�v���C���[�̃J�[�h���񕜂œG�̖��΂��A�΂̎�
        if (myCard.HasFlag(CardType.Heal) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))))
        {
            _player.Life -= 2;
        }
        //�v���C���[�̃J�[�h���K�E�Z�œG�̖��΂��A�΂̎�
        if (myCard.HasFlag(CardType.Special) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))))
        {
            _enemy.Life -= 2;
        }
        //  �v���C���[�̃J�[�h���K�E�Z�œG�̖��΂��ԁA���F�̎�
        if (myCard.HasFlag(CardType.Special) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _player.Life -= 2;
        }
        //�v���C���[�̃J�[�h���藠���œG�̖��΂��A���F�̎�
        if (myCard.HasFlag(CardType.Shuriken) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _enemy.Life -= 2;
        }
        //�v���C���[�̃J�[�h���藠���œG�̖��΂��ԁA���F�̎�
        if (myCard.HasFlag(CardType.Shuriken) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _player.Life -= 2;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��΁A���F�̎�
        if (myCard.HasFlag(CardType.Axe) && (enemyType.HasFlag(EnemyType.Green) || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _enemy.Life -= 2;
        }
        //�v���C���[�̃J�[�h�����œG�̖��΂��ԁA�̎�
        if (myCard.HasFlag(CardType.Shuriken) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))))
        {
            _player.Life -= 2;
        }
        //�v���C���[�̃J�[�h����œG�̖��΂��Ԃ̎�
        if (myCard.HasFlag(CardType.Staff) && (enemyType.HasFlag(EnemyType.Red)))
        {
            _enemy.Life -= 3;
        }
        //�v���C���[�̃J�[�h����œG�̖��΂��A���F�A�΂̎� 
        if (myCard.HasFlag(CardType.Staff) && (enemyType.HasFlag(EnemyType.Blue) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _player.Life -= 3;
        }
        //�v���C���[�̃J�[�h���}�V���K���œG�̖��΂��̎�
        if (myCard.HasFlag(CardType.Machinegun) && (enemyType.HasFlag(EnemyType.Blue)))
        {
            _enemy.Life -= 3;
        }
        //�v���C���[�̃J�[�h���}�V���K���œG�̖��΂��ԁA���F�A�΂̎� 
        if (myCard.HasFlag(CardType.Staff) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Green))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _player.Life -= 3;
        }
        //�v���C���[�̃J�[�h�����e�œG�̖��΂��΂̎�
        if (myCard.HasFlag(CardType.Bomb) && (enemyType.HasFlag(EnemyType.Green)))
        {
            _enemy.Life -= 3;
        }
        //�v���C���[�̃J�[�h���}�V���K���œG�̖��΂��ԁA���F�A�̎� 
        if (myCard.HasFlag(CardType.Bomb) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Yellow))))
        {
            _player.Life -= 3;
        }
        //�v���C���[�̃J�[�h���劙�œG�̖��΂����F�̎�
        if (myCard.HasFlag(CardType.Scythe) && (enemyType.HasFlag(EnemyType.Yellow)))
        {
            _enemy.Life -= 3;
        }
        //�v���C���[�̃J�[�h���}�V���K���œG�̖��΂��ԁA�΁A�̎� 
        if (myCard.HasFlag(CardType.Bomb) && (enemyType.HasFlag(EnemyType.Red) || (enemyType.HasFlag(EnemyType.Blue))
            || (enemyType.HasFlag(EnemyType.Green))))
        {
            _player.Life -= 3;
        }
    }
    public enum TurnResult
    {
        Success,
        Failure,
        Win,
        Lose,
    }
}
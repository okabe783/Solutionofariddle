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
        //�v���C���[�̃J�[�h�����œG�̖��΂��ԗΉ��F�̎�
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
        //�v���C���[�̃J�[�h���|�œG�̖��΂��Ή��F�̎�
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
    }
}
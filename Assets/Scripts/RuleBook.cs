using System;
using UnityEngine;
public class RuleBook : MonoBehaviour
{
    //���ʂ̕\��
    public void Result(Player _player, Enemy _enemy)
    {
        CardType myCard = CardType.None;
        EnemyType enemyType = EnemyType.None;

        // �J�[�h�̕]�����s����������
        if (myCard.HasFlag(CardType.Sword) && enemyType.HasFlag(EnemyType.Green))
        {
            _player.Life -= 1;
        }
    }
}
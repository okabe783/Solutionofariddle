using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Player _player;
    [SerializeField] Player _enemy;
    [SerializeField] CardGenerator _generator;
    private void Start()
    {
        SetUp();
    }

    //�J�[�h�𐶐����Ĕz��
    void SetUp()
    {
        for (int i = 0; i < 3; i++)
        {
            Card card = _generator.Spawn(i);  //�J�[�h�𐶐����ēn�����
            _player.SetCardToHand(card);  //�v���C���[�̎�D�ɒǉ�
        }
        _player.Hand.ResetPosition();

        //�G�ɖ��΂���n��
        for (int i = 0; i < 1; i++)
        {
            Card card = _generator.Spawn(i);
            _enemy.SetCardToHand(card);  //�v���C���[�̎�D�ɒǉ�
        }
        _enemy.Hand.ResetPosition();
    }
}

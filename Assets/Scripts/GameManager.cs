using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Player _player;
    [SerializeField] Player _enemy;
    [SerializeField] CardGenerator _generator;
    [SerializeField] GameObject _submitButton;
    RuleBook _ruleBook;

    private void Awake()
    {
        _ruleBook = GetComponent<RuleBook>();
    }
    private void Start()
    {
        SetUp();
    }

    //�J�[�h�𐶐����Ĕz��
    void SetUp()
    {
        _player.OnSubmitAction = SubmittedAction;
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
    void SubmittedAction()
    {
        Debug.Log("SubmitAction");
        if (_player.IsSubmitted)
        {
            _submitButton.SetActive(false); //Player���������������
        }
    }

    //Card�̃_���[�W����
    void CardBattle()
    {
        //�_���[�W��^���適�܂�
        SetUpNextTurn();
    }

    //�^�[�����I�������J�[�h������
    void SetUpNextTurn()
    {
        _player.SetUpNextTurn();
        _submitButton.SetActive(true); 

    }
}

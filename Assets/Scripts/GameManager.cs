using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Player _player;
    [SerializeField] Player _enemy;
    [SerializeField] CardGenerator _generator;
    [SerializeField] GameObject _submitButton;
    RuleBook _ruleBook;
    GameUI _gameUI;
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
        //���C�t�Ǘ�
        _player.Life = 10;
        _enemy.Life = 10;
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
    public void CardBattle()
    {
        SetUpNextTurn();
        //��������
        //�v���C���[�̃X�R�A��0�Ȃ�
    }

    //�^�[�����I�������J�[�h������
    void SetUpNextTurn()
    {
        _player.SetUpNextTurn();
        _submitButton.SetActive(true);
    }
    public void ShowResult()
    {
        //���s�p�l����\��
    }
}
using UnityEngine;
using static CardGenerator;
using static RuleBook;

public class GameManager : MonoBehaviour
{
    [SerializeField] Player _player;
    [SerializeField] Enemy _enemy;
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
            Card card = _generator.Spawn(SpawnType.Player);  //�J�[�h�𐶐����ēn�����
            _player.SetCardToHand(card);  //�v���C���[�̎�D�ɒǉ�
        }
        _player.Hand.ResetPosition();

        //�G�ɖ��΂���n��
        for (int i = 0; i < 1; i++)
        {
            Card card = _generator.Spawn(SpawnType.Enemy);
            _enemy.SetCardToHand(card);  //�v���C���[�̎�D�ɒǉ�
        }
        _enemy.Hand.ResetPosition();
    }
    void SubmittedAction()
    {
        if (_player.IsSubmitted && _enemy.IsSubmitted)
        {
            _submitButton.SetActive(false); //Player���������������
            CardBattle();
        }
        else if (_player.IsSubmitted)
        {
            _submitButton.SetActive(false); //�v���C���[���������������ύX�ł��Ȃ�����
            //�G�l�~�[����J�[�h���o��
            _enemy.RandomSubmit();
        }
        else if (_enemy.IsSubmitted)
        {
            //�v���C���[�̒�o��҂�
        }
    }

    //Card�̃_���[�W����
    public void CardBattle()
    {
        TurnResult result = _ruleBook.Result(_player, _enemy);
        //��������
        //���C�t���Ȃ��Ȃ������̏���
        _gameUI.ShowLife(_player.Life, _enemy.Life);
        if ((result == TurnResult.Win) || (result == TurnResult.Lose) || (_player.Life <= 0 || _enemy.Life <= 0)) 
        {
            ShowGameResult(result);
        }
        else
        {
            ShowResult(result);
            SetUpNextTurn();
        }
    }

    //�Q�[���̏��s��\������p�l��
    private void ShowGameResult(TurnResult result)
    {
        if (result == TurnResult.Win)
        {
            _gameUI.SetPanel("WIN");
        }
        else if (result == TurnResult.Lose)
        {
            _gameUI.SetPanel("LOSE");
        }
    }

    //�^�[�����I�������J�[�h������
    void SetUpNextTurn()
    {
        _player.SetUpNextTurn();
        _submitButton.SetActive(true);
    }
    public void ShowResult(TurnResult result)
    {
        //�U�������������s���̃p�l����\��
        if (result == TurnResult.Success)
        {
            _gameUI.SetPanel("Success");
        }
        else if (result == TurnResult.Failure)
        {
            _gameUI.SetPanel("Failure");
        }
    }
}
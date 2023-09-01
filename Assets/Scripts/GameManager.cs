using UnityEngine;
using static CardGenerator;
using static RuleBook;

public class GameManager : MonoBehaviour
{
    [SerializeField] Player _player;
    [SerializeField] Enemy _enemy;
    [SerializeField] CardGenerator _generator;
    [SerializeField] GameObject _submitButton;
    [SerializeField] GameUI _gameUI;
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
        _gameUI.Init();
        //���C�t�Ǘ�
        _player.Life = 10;
        _enemy.Life = 10;
        _gameUI.ShowLife(_player.Life, _enemy.Life);
        _player.OnSubmitAction = SubmittedAction;
        PlayerSendCard(_player); 
        EnemySendCard(_enemy); 
    }
    void SubmittedAction()
    {
        //�Ă΂�Ă��Ȃ�
        if (_player.IsSubmitted && _enemy.IsSubmitted)
        {
            _submitButton.SetActive(false); //Player���������������
            CardBattle();//�������Ăяo������
            Debug.Log("�o�g���X�^�[�g");
        }
        else if (_player.IsSubmitted)
        {
            //�������Ă΂�Ă��܂��Ă���
            _submitButton.SetActive(false); //�v���C���[���������������ύX�ł��Ȃ�����
            //�G�l�~�[����J�[�h���o��
            _enemy.RandomSubmit();
            Debug.Log("enemy���J�[�h�������܂����B");
            CardBattle();
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
        Debug.Log(result);
        switch (result)
        {
            case TurnResult.Success1:
                _gameUI.ShowTurnResult("Success");
                _enemy.Life--;
                break;
            case TurnResult.Success2:
                _gameUI.ShowTurnResult("Success");
                _enemy.Life-= 2;
                break;
            case TurnResult.Success3:
                _gameUI.ShowTurnResult("Success");
                _enemy.Life-= 3;
                break;
            case TurnResult.Failure1:
                _gameUI.ShowTurnResult("Failure");
                _enemy.Life--;
                break;
                case TurnResult.Failure2:
                _gameUI.ShowTurnResult("Failure");
                _enemy.Life-= 2;
                break;
                case TurnResult.Failure3:
                _gameUI.ShowTurnResult("Failure");
                _enemy.Life-= 3;
                break;
        }
        //���C�t���Ȃ��Ȃ������̏���
        _gameUI.ShowLife(_player.Life, _enemy.Life);
        if ((result == TurnResult.GameWin) || (result == TurnResult.GameLose) || (_player.Life <= 0 || _enemy.Life <= 0)) 
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
        if (result == TurnResult.GameWin)
        {
            _gameUI.SetPanel("WIN");
        }
        else if (result == TurnResult.GameLose)
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
        //���s�p�l����\��
        if (result == TurnResult.GameWin)
        {
            _gameUI.SetPanel("WIN");
        }
        else if (result == TurnResult.GameLose)
        {
            _gameUI.SetPanel("Failure");
        }
        else if(_player.Life <= 0)
        {
            _gameUI.ShowGameResult("LOSE");
        }
        else if (_enemy.Life <= 0)
        {
            _gameUI.SetPanel("WIN");
        }
    }
    public void PlayerSendCard(Player _player)
    {
        for (int i = 0; i < 3; i++)
        {
            Card card = _generator.Spawn(SpawnType.Player);  //�J�[�h�𐶐����ēn�����
            _player.SetCardToHand(card);  //�v���C���[�̎�D�ɒǉ�
        }
        _player.Hand.ResetPosition();
    }
    public void EnemySendCard(Enemy _enemy)
    {
        //�G�ɖ��΂���n��
        for (int i = 0; i < 1; i++)
        {
            Card card = _generator.Spawn(SpawnType.Enemy);
            _enemy.SetCardToHand(card);  //�G�̎�D�ɒǉ�
        }
        _enemy.Hand.ResetPosition();
    }
}
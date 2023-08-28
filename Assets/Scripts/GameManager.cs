using System.Collections;
using UnityEngine;
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
        TurnResult result =_ruleBook.Result(_player, _enemy);
        //��������
        //���C�t���Ȃ��Ȃ������̏���
        _gameUI.ShowLife(_player.Life, _enemy.Life);
        if ((result == TurnResult.Win) || (result == TurnResult.Lose) || (_player.Life <= 0 || _enemy.Life <= 0)) //���C�t��0�Ȃ�Q�[���I�[�o�[
        {
            ShowResult(result);
        }
        else
        {
            SetUpNextTurn();  
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
        if(result == TurnResult.Success)
        {
            _gameUI.SetPanel("Success");
        }
        else if(result == TurnResult.Failure)
        {
            _gameUI.SetPanel("Failure");
        }
    }
}
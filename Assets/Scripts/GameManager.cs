using UnityEngine;
using static CardGenerator;
using static RuleBook;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Player _player;
    [SerializeField] Enemy _enemy;
    [SerializeField] CardGenerator _generator;
    [SerializeField] GameObject _submitButton;
    [SerializeField] GameUI _gameUI;
    [SerializeField] PlayerHand _playerHand;
    [SerializeField] PlayerHand _enemyHand;
    [SerializeField] SubmitPosition _playerSubmitCard;
    [SerializeField] SubmitPosition _enemySubmitCard;
    [SerializeField] PlayerHandMovement _playerHandMovement;
    [SerializeField] SubmitPosition _submitPosition;
    [SerializeField] GameObject _effect;
    [SerializeField] EnemyAnimController _enemyAnimController;
    [SerializeField] ResultData _resultData;
    RuleBook _ruleBook;
    private int _enemyCardCount = 0;
    private void Awake()
    {
        _ruleBook = GetComponent<RuleBook>();
    }
    private void Start()
    {
        SetUp();
    }

    void SetUp()
    {
        _gameUI.Init();
        //���C�t�Ǘ�
        _player.Life = _enemy.Life = 10;
        _gameUI.ShowLife(_player.Life, _enemy.Life);
        _player.OnSubmitAction = _enemy.OnSubmitAction = SubmittedAction;
        PlayerSendCard(_player);
        EnemySendCard(_enemy);
    }

    //player��enemy����o�������ǂ������m�F���A������o���Ă����ꍇCardBattle��������
    //enemy����o�����ꍇenemy�Ƀ����_���ɃJ�[�h���o������
    void SubmittedAction()
    {
        if (_player.IsSubmitted && _enemy.IsSubmitted)
        {
            _submitButton.SetActive(false); //Player���������������
            CardBattle();
            _submitPosition.AttackEffect();
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
    //player��enemy�̃J�[�h���擾�����[���u�b�N���g�p���ăo�g�����ʂ��v�Z
    //���ʂ�UI�ɕ\��
    void CardBattle()
    {
        PlayerType playerType = _playerSubmitCard.SubmitCard.Base.PlayerType;
        EnemyType enemyType = _enemySubmitCard.SubmitCard.Base.EnemyType;
        TurnResult result = _ruleBook.Result(playerType, enemyType);
        string resultText = (result == TurnResult.Success1 || result == TurnResult.Success2 || result == TurnResult.Success3) ? "Success" : "Failure";
        _gameUI.ShowTurnResult(resultText);
        if (result == TurnResult.Success1)
        {
            _enemy.Life--;
            Invoke("EnemyEffect", 0.5f);
        }
        else if (result == TurnResult.Success2)
        {
            _enemy.Life -= 2;
            Invoke("EnemyEffect", 0.5f);
        }
        else if (result == TurnResult.Success3)
        {
            _enemy.Life -= 3;
            Invoke("EnemyEffect", 0.5f);
        }
        else if (result == TurnResult.Failure1)
        {
            _player.Life -= 2;
            Invoke("PlayerEffect", 0.5f);
        }
        else if (result == TurnResult.Failure2)
        {
            _player.Life -= 2;
            Invoke("PlayerEffect", 0.5f);
        }
        else if (result == TurnResult.Failure3)
        {
            _player.Life -= 3;
            Invoke("PlayerEffect", 0.5f);
        }
        //���C�t��0�ɂȂ����v���C���[������Ώ��s�p�l����\���@�Ō�ɓG�̑�����\��
        _gameUI.ShowLife(_player.Life, _enemy.Life);
        if (result == TurnResult.GameWin || _enemy.Life <= 0)
        {
            _resultData.SetResult(MatchData.WIN);
            OnTitleButton();
        }
        else if (result == TurnResult.GameLose || _player.Life <= 0)
        {
            _resultData.SetResult(MatchData.LOSE);
            OnTitleButton();
        }
        else
            Invoke("SetUpNextTurn", 0.8f);
    }
    //�^�[�����I�������Ƃ��A�v���C���[�̃J�[�h�����Z�b�g���V�����J�[�h�𐶐����Ď�D�ɒǉ�����
    //��o�{�^�����A�N�e�B�u�ɂ���
    void SetUpNextTurn()
    {
        _player.TurnChange();
        _submitButton.SetActive(true);
        _playerHand.ResetCard();
        PlayerSendCard(_player);
        _player.Hand.ResetPosition();
        EnemyRedistributeCards();
        _playerHandMovement.StartMove();
    }
    //�v���C���[�ɃJ�[�h�������_���ɔz��A��D�̈ʒu�����Z�b�g����
    public void PlayerSendCard(Player _player)
    {
        for (int i = 0; i < 3; i++)
        {
            Card card = _generator.Spawn(SpawnType.Player);  //�J�[�h�𐶐����ēn�����
            _player.SetCardToHand(card);  //�v���C���[�̎�D�ɒǉ�
        }
        _player.Hand.ResetPosition();
    }
    //enemy�ɃJ�[�h�������_���ɔz��A��D�̈ʒu�����Z�b�g����
    public void EnemySendCard(Enemy _enemy)
    {
        Card card = _generator.Spawn(SpawnType.Enemy);
        _enemy.SetCardToHand(card);
        _enemy.Hand.ResetPosition();
        _resultData.SetEnemyAttribute(card.Base.CardName);
    }
    public void EnemyRedistributeCards()
    {
        _enemyCardCount++;
        if (_enemyCardCount == 6)
        {
            _gameUI.ChangeAttribute();
            _enemy.TurnChange();
            _enemyHand.ResetCard();
            EnemySendCard(_enemy);
            _enemyAnimController.ChangeAttribute();
        }
    }
    void PlayerEffect()
    {
        Transform p = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        Instantiate(_effect, p.position, Quaternion.identity);
    }
    void EnemyEffect()
    {
        Transform trn = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        Instantiate(_effect, trn.position, Quaternion.identity);
    }
    public void OnRetryButton()
    {
        string currntSnene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currntSnene);
    }
    public void OnTitleButton()
    {
        SceneManager.LoadScene("GameResult");
    }
    public enum MatchData
    {
        WIN,
        LOSE,
    }
}
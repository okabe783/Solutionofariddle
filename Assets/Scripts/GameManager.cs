using UnityEngine;
using static CardGenerator;
using static RuleBook;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private CardGenerator _generator;
    [SerializeField] private GameObject _submitButton;
    [SerializeField] private GameUI _gameUI;
    [SerializeField] private PlayerHand _playerHand;
    [SerializeField] private PlayerHand _enemyHand;
    [SerializeField] private SubmitPosition _playerSubmitCard;
    [SerializeField] private SubmitPosition _enemySubmitCard;
    [SerializeField] private PlayerHandMovement _playerHandMovement;
    [SerializeField] private SubmitPosition _submitPosition;
    [SerializeField] private GameObject _effect;
    [SerializeField] private EnemyAnimController _enemyAnimController;
    [SerializeField] private ResultData _resultData;
    private RuleBook _ruleBook;
    private int _enemyCardCount;
    private void Awake()
    {
        _ruleBook = GetComponent<RuleBook>();
    }
    private void Start()
    {
        SetUp();
    }

    private void SetUp()
    {
        _gameUI.Init();
        //ライフ管理
        _player.Life = _enemy.Life = 10;
        _gameUI.ShowLife(_player.Life, _enemy.Life);
        _player.OnSubmitAction = _enemy.OnSubmitAction = SubmittedAction;
        PlayerSendCard(_player);
        EnemySendCard(_enemy);
    }

    //playerとenemyが提出したかどうかを確認し、両方提出していた場合CardBattleをさせる
    //enemyが提出した場合enemyにランダムにカードを提出させる
    private void SubmittedAction()
    {
        if (_player.IsSubmitted && _enemy.IsSubmitted)
        {
            _submitButton.SetActive(false); //Playerが決定をおしたら
            CardBattle();
            _submitPosition.AttackEffect();
        }
        else if (_player.IsSubmitted)
        {
            _submitButton.SetActive(false); //プレイヤーが決定を押したら変更できなくする
            //エネミーからカードを出す
            _enemy.RandomSubmit();
        }
        else if (_enemy.IsSubmitted)
        {
            //プレイヤーの提出を待つ
        }
    }
    //playerとenemyのカードを取得しルールブックを使用してバトル結果を計算
    //結果をUIに表示
    void CardBattle()
    {
        var playerType = _playerSubmitCard.SubmitCard.Base.PlayerType;
        var enemyType = _enemySubmitCard.SubmitCard.Base.EnemyType;
        var result = _ruleBook.Result(playerType, enemyType);
        var resultText = (result == TurnResult.Success1 || result == TurnResult.Success2 || result == TurnResult.Success3) ? "Success" : "Failure";
        _gameUI.ShowTurnResult(resultText);
        if (result == TurnResult.Success1)
        {
            _enemy.Life--;
        }
        else if (result == TurnResult.Success2)
        {
            _enemy.Life -= 2;
        }
        else if (result == TurnResult.Success3)
        {
            _enemy.Life -= 3;
        }
        else if (result == TurnResult.Failure1)
        {
            _player.Life -= 2;
        }
        else if (result == TurnResult.Failure2)
        {
            _player.Life -= 2;
        }
        else if (result == TurnResult.Failure3)
        {
            _player.Life -= 3;
        }
        //ライフが0になったプレイヤーがいれば勝敗パネルを表示　最後に敵の属性を表示
        _gameUI.ShowLife(_player.Life, _enemy.Life);
        if (result == TurnResult.GameWin || _enemy.Life <= 0)
        {
            _resultData.SetResult(MatchData.WIN);
        }
        else if (result == TurnResult.GameLose || _player.Life <= 0)
        {
            _resultData.SetResult(MatchData.LOSE);
        }
        else
            Invoke(nameof(SetUpNextTurn), 0.8f);
    }
    //ターンが終了したとき、プレイヤーのカードをリセットし新しいカードを生成して手札に追加する
    //提出ボタンをアクティブにする
    private void SetUpNextTurn()
    {
        _player.TurnChange();
        _submitButton.SetActive(true);
        _playerHand.ResetCard();
        PlayerSendCard(_player);
        _player.Hand.ResetPosition();
        EnemyRedistributeCards();
        _playerHandMovement.StartMove();
    }
    //プレイヤーにカードをランダムに配り、手札の位置をリセットする
    public void PlayerSendCard(Player _player)
    {
        for (int i = 0; i < 3; i++)
        {
            Card card = _generator.Spawn(SpawnType.Player);  //カードを生成して渡される
            _player.SetCardToHand(card);  //プレイヤーの手札に追加
        }
        _player.Hand.ResetPosition();
    }
    //enemyにカードをランダムに配り、手札の位置をリセットする
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
}
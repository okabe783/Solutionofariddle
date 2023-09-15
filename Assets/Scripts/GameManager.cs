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
    [SerializeField] PlayerHand _playerHand;
    [SerializeField] PlayerHand _enemyHand;
    [SerializeField] SubmitPosition _playerSubmitCard;
    [SerializeField] SubmitPosition _enemySubmitCard;
    [SerializeField] PlayerHandMovement _playerHandMovement;
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
        //ライフ管理
        _player.Life = _enemy.Life = 10;        
        _gameUI.ShowLife(_player.Life, _enemy.Life);
        _player.OnSubmitAction = _enemy.OnSubmitAction = SubmittedAction;
        PlayerSendCard(_player);
        EnemySendCard(_enemy);
    }

    //playerとenemyが提出したかどうかを確認し、両方提出していた場合CardBattleをさせる
    //enemyが提出した場合enemyにランダムにカードを提出させる
    void SubmittedAction()
    {
        if (_player.IsSubmitted && _enemy.IsSubmitted)
        {
            _submitButton.SetActive(false); //Playerが決定をおしたら
            CardBattle();
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
        PlayerType playerType = _playerSubmitCard.SubmitCard.Base.PlayerType;
        EnemyType enemyType = _enemySubmitCard.SubmitCard.Base.EnemyType;
        TurnResult result = _ruleBook.Result(playerType, enemyType);
        string resultText = (result == TurnResult.Success1 || result == TurnResult.Success2 || result == TurnResult.Success3) ? "Success" : "Failure";
        _gameUI.ShowTurnResult(resultText);
        if (result == TurnResult.Success1)
            _enemy.Life--;
        else if (result == TurnResult.Success2)
            _enemy.Life -= 2;
        else if (result == TurnResult.Success3)
            _enemy.Life -= 3;
        else if (result == TurnResult.Failure1)
            _player.Life--;
        else if (result == TurnResult.Failure2)
            _player.Life -= 2;
        else if (result == TurnResult.Failure3)
            _player.Life -= 3;

        _gameUI.ShowLife(_player.Life, _enemy.Life);

        if (result == TurnResult.GameWin)
            ShowGameResult("WIN");
        else if (result == TurnResult.GameLose || _player.Life <= 0)
            ShowGameResult("LOSE");
        else
            SetUpNextTurn();
    }

    void ShowGameResult(string resultText)
    {
        _gameUI.SetPanel(resultText);
    }
    //ターンが終了したとき、プレイヤーのカードをリセットし新しいカードを生成して手札に追加する
    //提出ボタンをアクティブにする
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
    }
    public void EnemyRedistributeCards()
    {
        _enemyCardCount++;
        if (_enemyCardCount == 5)
        {
            _enemy.TurnChange();
            _enemyHand.ResetCard();
            EnemySendCard(_enemy);
            Debug.Log("殺す");
        }
    }
}
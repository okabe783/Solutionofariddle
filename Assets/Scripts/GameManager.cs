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

    //カードを生成して配る
    void SetUp()
    {
        _gameUI.Init();
        //ライフ管理
        _player.Life = 10;
        _enemy.Life = 10;
        _gameUI.ShowLife(_player.Life, _enemy.Life);
        _player.OnSubmitAction = SubmittedAction;
        PlayerSendCard(_player); 
        EnemySendCard(_enemy); 
    }
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

    //Cardのダメージ判定
    public void CardBattle()
    {
        TurnResult result = _ruleBook.Result(_player, _enemy);

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
        //ライフがなくなった時の処理
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

    //ゲームの勝敗を表示するパネル
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

    //ターンが終わったらカードを消す
    void SetUpNextTurn()
    {
        _player.SetUpNextTurn();
        _submitButton.SetActive(true);
    }
    public void ShowResult(TurnResult result)
    {
        //攻撃が成功か失敗かのパネルを表示
        if (result == TurnResult.GameWin)
        {
            _gameUI.SetPanel("WIN");
        }
        else if (result == TurnResult.GameLose)
        {
            _gameUI.SetPanel("Failure");
        }
    }
    public void PlayerSendCard(Player _player)
    {
        for (int i = 0; i < 3; i++)
        {
            Card card = _generator.Spawn(SpawnType.Player);  //カードを生成して渡される
            _player.SetCardToHand(card);  //プレイヤーの手札に追加
        }
        _player.Hand.ResetPosition();
    }
    public void EnemySendCard(Enemy _enemy)
    {
        //敵に魔石を一つ渡す
        for (int i = 0; i < 1; i++)
        {
            Card card = _generator.Spawn(SpawnType.Enemy);
            _enemy.SetCardToHand(card);  //敵の手札に追加
        }
        _enemy.Hand.ResetPosition();
    }
}
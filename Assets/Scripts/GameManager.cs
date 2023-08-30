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

    //カードを生成して配る
    void SetUp()
    {
        //ライフ管理
        _player.Life = 10;
        _enemy.Life = 10;
        _player.OnSubmitAction = SubmittedAction;
        for (int i = 0; i < 3; i++)
        {
            Card card = _generator.Spawn(SpawnType.Player);  //カードを生成して渡される
            _player.SetCardToHand(card);  //プレイヤーの手札に追加
        }
        _player.Hand.ResetPosition();

        //敵に魔石を一つ渡す
        for (int i = 0; i < 1; i++)
        {
            Card card = _generator.Spawn(SpawnType.Enemy);
            _enemy.SetCardToHand(card);  //プレイヤーの手札に追加
        }
        _enemy.Hand.ResetPosition();
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
        //勝利判定
        //ライフがなくなった時の処理
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

    //ゲームの勝敗を表示するパネル
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

    //ターンが終わったらカードを消す
    void SetUpNextTurn()
    {
        _player.SetUpNextTurn();
        _submitButton.SetActive(true);
    }
    public void ShowResult(TurnResult result)
    {
        //攻撃が成功か失敗かのパネルを表示
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
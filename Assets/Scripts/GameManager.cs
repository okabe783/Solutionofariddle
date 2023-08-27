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

    //カードを生成して配る
    void SetUp()
    {
        //ライフ管理
        _player.Life = 10;
        _enemy.Life = 10;
        _player.OnSubmitAction = SubmittedAction;
        for (int i = 0; i < 3; i++)
        {
            Card card = _generator.Spawn(i);  //カードを生成して渡される
            _player.SetCardToHand(card);  //プレイヤーの手札に追加
        }
        _player.Hand.ResetPosition();

        //敵に魔石を一つ渡す
        for (int i = 0; i < 1; i++)
        {
            Card card = _generator.Spawn(i);
            _enemy.SetCardToHand(card);  //プレイヤーの手札に追加
        }
        _enemy.Hand.ResetPosition();
    }
    void SubmittedAction()
    {
        Debug.Log("SubmitAction");
        if (_player.IsSubmitted)
        {
            _submitButton.SetActive(false); //Playerが決定をおしたら
        }
    }

    //Cardのダメージ判定
    public void CardBattle()
    {
        SetUpNextTurn();
        //勝利判定
        //プレイヤーのスコアが0なら
    }

    //ターンが終わったらカードを消す
    void SetUpNextTurn()
    {
        _player.SetUpNextTurn();
        _submitButton.SetActive(true);
    }
    public void ShowResult()
    {
        //勝敗パネルを表示
    }
}
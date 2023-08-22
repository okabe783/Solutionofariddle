using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Player _player;
    [SerializeField] Player _enemy;
    [SerializeField] CardGenerator _generator;
    private void Start()
    {
        SetUp();
    }

    //カードを生成して配る
    void SetUp()
    {
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
}

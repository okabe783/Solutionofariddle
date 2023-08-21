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
            _player.Hand.Add(card);  //プレイヤーの手札に追加
        }
        _player.Hand.ResetPosition();
    }
}

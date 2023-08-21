using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] Card cardprefab;

    private void Start()
    {
        //カードを3枚配る
        for (int i = 1; i <= 3; i++)
        {
            Spawn();
        }
    }
    //Cardの生成
    public void Spawn()
    {
        Instantiate(cardprefab);
    }
}

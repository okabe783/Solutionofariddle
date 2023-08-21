using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] CardBase[] cardBases;
    [SerializeField] Card cardprefab;

    private void Start()
    {
        //カードを3枚配る
        for (int i = 1; i <= 3; i++)
        {
            Spawn(i);
        }
    }
    //Cardの生成
    public void Spawn(int number)
    {
       Card card = Instantiate(cardprefab);
       card.Set(cardBases[number]);
    }
}

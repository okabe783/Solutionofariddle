using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] CardBase[] cardBases;
    [SerializeField] Card cardprefab;

    //Cardの生成して返す
    public Card Spawn(int number)
    {
       Card card = Instantiate(cardprefab);
       card.Set(cardBases[number]);
        return card;
    }
}

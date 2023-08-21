using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] CardBase[] cardBases;
    [SerializeField] Card cardprefab;

    //Card�̐������ĕԂ�
    public Card Spawn(int number)
    {
       Card card = Instantiate(cardprefab);
       card.Set(cardBases[number]);
        return card;
    }
}

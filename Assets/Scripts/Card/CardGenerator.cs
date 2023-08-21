using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] CardBase[] cardBases;
    [SerializeField] Card cardprefab;

    //Card‚Ì¶¬‚µ‚Ä•Ô‚·
    public Card Spawn(int number)
    {
       Card card = Instantiate(cardprefab);
       card.Set(cardBases[number]);
        return card;
    }
}

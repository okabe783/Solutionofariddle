using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] CardBase[] _playercardBases;
    [SerializeField] CardBase[] _enemycardBases;
    [SerializeField] Card cardprefab;

    //Cardを生成して返す
    public Card Spawn(SpawnType spawnType)
    {
        int randomIndex = 0;
        Card card = Instantiate(cardprefab);
        if (spawnType == SpawnType.Enemy)
        {
             randomIndex = Random.Range(0, _enemycardBases.Length);
            card.CardSet(_enemycardBases[randomIndex]);
        }
        else
        {
             randomIndex = Random.Range(0, _playercardBases.Length);
            card.CardSet(_playercardBases[randomIndex]);
        }
        return card;
    }
}

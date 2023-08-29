using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] CardBase[] _playercardBases;
    [SerializeField] CardBase[] _enemycardBases;
    [SerializeField] Card cardprefab;

    //Card‚ğ¶¬‚µ‚Ä•Ô‚·

    public Card Spawn(SpawnType spawnType)
    {
        int randomIndex = 0;
        if (spawnType == SpawnType.Enemy)
        {
             randomIndex = Random.Range(0, _enemycardBases.Length);
        }
        else
        {
             randomIndex = Random.Range(0, _playercardBases.Length);

        }
        Card card = Instantiate(cardprefab);
        card.Set(_playercardBases[randomIndex]);
        return card;
    }
    public enum SpawnType
    {
        Enemy,
        Player,
    }
}

using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] Card cardprefab;

    private void Start()
    {
        Spawn();
    }
    //Card‚Ì¶¬
    public void Spawn()
    {
        Instantiate(cardprefab);
    }
}

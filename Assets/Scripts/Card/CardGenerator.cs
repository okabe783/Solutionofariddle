using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] Card cardprefab;

    private void Start()
    {
        Spawn();
    }
    //Card�̐���
    public void Spawn()
    {
        Instantiate(cardprefab);
    }
}

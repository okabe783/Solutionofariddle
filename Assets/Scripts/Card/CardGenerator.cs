using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] CardBase[] cardBases;
    [SerializeField] Card cardprefab;

    private void Start()
    {
        //�J�[�h��3���z��
        for (int i = 1; i <= 3; i++)
        {
            Spawn(i);
        }
    }
    //Card�̐���
    public void Spawn(int number)
    {
       Card card = Instantiate(cardprefab);
       card.Set(cardBases[number]);
    }
}

using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] Card cardprefab;

    private void Start()
    {
        //�J�[�h��3���z��
        for (int i = 1; i <= 3; i++)
        {
            Spawn();
        }
    }
    //Card�̐���
    public void Spawn()
    {
        Instantiate(cardprefab);
    }
}

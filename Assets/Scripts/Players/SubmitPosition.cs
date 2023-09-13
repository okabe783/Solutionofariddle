using UnityEngine;

public class SubmitPosition : MonoBehaviour
{
    public Transform defaultParent;
    //�I�����ꂽ�J�[�h���Ǘ�����
    Card submitCard;

    public Card SubmitCard { get => submitCard; }

    //�����̎q�v�f�ɂ���E�ʒu�������̏ꏊ�ɂ���
    public void Set(Card card)
    {
        submitCard = card;
        card.transform.SetParent(transform);
        card.transform.position = transform.position;
    }

    //��D�̃J�[�h������
    public void DestroyCard()
    {
        Destroy(submitCard.gameObject);
        submitCard = null;
    }
}
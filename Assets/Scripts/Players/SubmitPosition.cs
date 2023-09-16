using UnityEngine;
using DG.Tweening;
using System.Collections;

public class SubmitPosition : MonoBehaviour
{
    //�I�����ꂽ�J�[�h���Ǘ�����
    Card submitCard;

    public Card SubmitCard => submitCard;

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
    public void AttackEffect()
    {
        this.transform.DOMoveX(4, 0.25f).SetLoops(2, LoopType.Yoyo);
    }
}
using UnityEngine;
using DG.Tweening;
public class SubmitPosition : MonoBehaviour
{
    //選択されたカードを管理する
    public Card SubmitCard { get; private set; }

    //自分の子要素にする・位置を自分の場所にする
    public void Set(Card card)
    {
        SubmitCard = card;
        card.transform.SetParent(transform);
        card.transform.position = transform.position;
    }
    //手札のカードを消す
    public void DestroyCard()
    {
        Destroy(SubmitCard.gameObject);
        SubmitCard = null;
    }
    public void AttackEffect()
    {
        this.transform.DOMoveX(4, 0.25f).SetLoops(2, LoopType.Yoyo);
    }
}
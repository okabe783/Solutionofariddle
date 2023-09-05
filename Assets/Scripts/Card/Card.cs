using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Card : MonoBehaviour
{
    //�J�[�hUI
    //�Q�[�����̏���
    [SerializeField] Image icon;
    [SerializeField] Text descriptionText;
    public CardBase Base { get; private set; }

    //UnityAction�͊֐���o�^����
    public UnityAction<Card> OnClickCard;
    public void CardSet(CardBase cardBase)
    {
        Base = cardBase;
        icon.sprite = cardBase.Icon1;
        descriptionText.text = cardBase.Description;
    }
    public void OnClick()
    {
        OnClickCard?.Invoke(this);
    }
}

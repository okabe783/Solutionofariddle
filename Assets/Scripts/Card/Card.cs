using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Card : MonoBehaviour
{
    //�J�[�hUI
    //�Q�[�����̏���
    [SerializeField] private Image icon;
    [SerializeField] private Text descriptionText;
    public CardBase Base { get; private set; }

    //UnityAction�͊֐���o�^����
    //�J�[�h���N���b�N���ꂽ�Ƃ��ɓ���̃A�N�V���������s����
    public UnityAction<Card> OnClickCard;
    
    //�J�[�h�̊O�ς�ݒ�
    public void CardSet(CardBase cardBase)
    {
        Base = cardBase;
        icon.sprite = cardBase.Icon1;
        descriptionText.text = cardBase.Description;
    }
    //�J�[�h���N���b�N���ꂽ�Ƃ�
    public void OnClick()
    {
        OnClickCard?.Invoke(this);�@//�J�[�h���N���b�N���ꂽ���Ƃ�ʒm
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Entity : MonoBehaviour
{
    [SerializeField] PlayerHand _hand;
    [SerializeField] SubmitPosition _submitposition;
    public bool IsSubmitted { get; private set; }
    public UnityAction OnSubmitAction;
    public PlayerHand Hand { get => _hand; }
    public Card SubmitCard { get => _submitposition.SubmitCard; }
    public int Life { get; set; }
    public void SetCardToHand(Card card) //�J�[�h�����̃^�C�~���O�ŔF������
    {
        //�J�[�h���z��ꂽ���Ɏ����̊֐���o�^���Ă���
        _hand.Add(card);
        card.OnClickCard = SelectedCard;
    }
    void SelectedCard(Card card)
    {
        if (IsSubmitted == true)
        {
            return;
        }
        //���łɃZ�b�g���Ă���΁A��D�ɖ߂�
        if (_submitposition.SubmitCard)
        {
            _hand.Add(_submitposition.SubmitCard);
        }
        _hand.Remove(card);
        _submitposition.Set(card);
        _hand.ResetPosition();
    }
    public void OnSubmitButton()
    {
        //�J�[�h�̌���A�ύX�s��
        IsSubmitted = true;
        //Manager�ɒʒm
        OnSubmitAction?.Invoke();
    }
    public void SetUpNextTurn()
    {
        IsSubmitted = false;
        _submitposition.DestroyCard();
    }
}

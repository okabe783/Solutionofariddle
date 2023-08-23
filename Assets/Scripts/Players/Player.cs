using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] PlayerHand _hand;
    [SerializeField] SubmitPosition _submitposition;
    bool _isSubmitted;
    public UnityAction OnSubmitAction;
    public PlayerHand Hand { get => _hand; }

    public void SetCardToHand(Card card) //�J�[�h�����̃^�C�~���O�ŔF������
    {
        
        //�J�[�h���z��ꂽ���Ɏ����̊֐���o�^���Ă���
        _hand.Add(card);
        card.OnClickCard = SelectedCard;
    }
    void SelectedCard(Card card)
    {
        if (_isSubmitted == true)
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
        _isSubmitted = true;
        //Manager�ɒʒm
        OnSubmitAction?.Invoke();
    }
}

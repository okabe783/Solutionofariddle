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

    //entity�ɃJ�[�h��ǉ�
    //�N���b�N���ꂽ�Ƃ��ɑI�����ꂽ�J�[�h���ړ�
    public void SetCardToHand(Card card) 
    {
        //�J�[�h���z��ꂽ���Ɏ����̊֐���o�^���Ă���
        Hand.Add(card);
        card.OnClickCard = SelectedCard;
    }
    //��D�̃J�[�h��I�����ꂽ�Ƃ��ɒ�o�ʒu�ɃZ�b�g
    void SelectedCard(Card card)
    {
        if (IsSubmitted)
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

    //�{�^���������ꂽ�Ƃ���o���ꂽ���Ƃ�gamemanager�ɒʒm
    public void OnSubmitButton()
    {
        if (_submitposition.SubmitCard)
        {
            //�J�[�h�̌���A�ύX�s��
            IsSubmitted = true;
            //Manager�ɒʒm
            OnSubmitAction?.Invoke();
        }
    }
    //enemy�������_���ɃJ�[�h���o����
    public void RandomSubmit()
    {
        //��D���烉���_���ɃJ�[�h�𔲂���適������ύX
        Card card = _hand.RandomRemove();
        //��o�p�ɃZ�b�g
        _submitposition.Set(card);
        //�Q�[���}�l�[�W���ɒʒm����
        IsSubmitted = true;
        OnSubmitAction?.Invoke();
        _hand.ResetPosition();

    }

    //��o�����J�[�h���폜
    public void TurnChange()
    {
        IsSubmitted = false;
        _submitposition.DestroyCard();
    }
}
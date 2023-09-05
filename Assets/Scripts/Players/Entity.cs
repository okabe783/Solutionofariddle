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
        Hand.Add(card);
        card.OnClickCard = SelectedCard;
    }
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
    public void OnSubmitButton()
    {
        if(_submitposition.SubmitCard)
        {
            //�J�[�h�̌���A�ύX�s��
            IsSubmitted = true;
            //Manager�ɒʒm
            OnSubmitAction?.Invoke();
        }
    }

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
    public void SetUpNextTurn()
    {
        IsSubmitted = false;
        _submitposition.DestroyCard();
    }
}
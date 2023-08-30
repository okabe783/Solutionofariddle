using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
  List<Card> list = new List<Card>();

    //list�ɒǉ����Ď����̎q�v�f�ɂ���
    public void Add(Card card)
    {
        list.Add(card);
        card.transform.SetParent(this.transform); //�e�Ƃ��Ď������g���q�v�f�ɂ���
    }
    public void Remove(Card card)
    {
        list.Remove(card);
    }

    //��D�𐮗�����
    public void ResetPosition() //��D�̃J�[�h�𐮗񂳂���
    {
        //���������ɕ��ׂ�
        list.Sort((card0, card1) => card0.Base.CardNumber - card1.Base.CardNumber);

        for (int i = 0; i < list.Count; i++)
        {
            float posX = i * 2f; //�Y��ɐ��񂳂���
            list[i].transform.localPosition = new Vector2(posX, 0);
        }
    }
    public Card RandomRemove()
    {
        int r =Random.Range(0, list.Count);
        Card card = list[r];
        Remove(card);
        return card;
    }
}

using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    List<Card> list = new List<Card>();

    //�e��PlayerHand�ɂ��ăJ�[�h�����̎q�v�f�ɂ���
    public void Add(Card card)
    {
        list.Add(card);
        card.transform.SetParent(this.transform); //�������g���q�v�f�ɂ���
    }
    //�w�肳�ꂽ�J�[�h���폜����
    public void Remove(Card card)
    {
        list.Remove(card);
    }

    //��D�𐮗�����
    public void ResetPosition() 
    {
        //���������ɕ��ׂ�
        list.Sort((card0, card1) => card0.Base.CardNumber - card1.Base.CardNumber);
        for (int i = 0; i < list.Count; i++)
        {
            float posX = i * 2f; //�Y��ɐ��񂳂���
            list[i].transform.localPosition = new Vector2(posX, 0);
        }
    }
    //�G�������_���ɃJ�[�h���o�����߂̃��\�b�h
    public Card RandomRemove()
    {
        if (list.Count == 0)
        {
            return null;
        }
        int r = Random.Range(0, list.Count);
        Card card = list[r];
        return card;
    }
    //��D���폜���V�����J�[�h��ǉ�����
    public void GiveNewHand(List<Card> newCards)
    {
        foreach(var card in list)
        {
            Destroy(card.gameObject);
        }
        list.Clear();
        foreach(var card in newCards)
        {
            Add(card);
        }
        ResetPosition();
        //for (int i = 0; i < transform.childCount; i++)
        //{
        //    Destroy(transform.GetChild(i).gameObject);
        //}
    }
}
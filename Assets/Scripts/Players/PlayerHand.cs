using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
  List<Card> list = new List<Card>();

    //list�ɒǉ����Ď����̎q�v�f�ɂ���
    public void Add(Card card)
    {
        list.Add(card);
        card.transform.SetParent(this.transform); //�e�Ƃ��Ď������M���q�v�f�ɂ���
    }
    public void Remove(Card card)
    {
        list.Remove(card);
    }

    public void ResetPosition() //��D�̃J�[�h�𐮗񂳂���
    {
        for (int i = 0; i < list.Count; i++)
        {
            float posX = i * 2f; //�Y��ɐ��񂳂���
            list[i].transform.localPosition = new Vector2(posX, 0);
        }
    }
}

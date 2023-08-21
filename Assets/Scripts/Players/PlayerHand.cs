using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
  List<Card> list = new List<Card>();

    //listに追加して自分の子要素にする
    public void Add(Card card)
    {
        list.Add(card);
        card.transform.SetParent(this.transform); //親として自分自信を子要素にする
    }
    public void Remove(Card card)
    {
        list.Remove(card);
    }

    public void ResetPosition() //手札のカードを整列させる
    {
        for (int i = 0; i < list.Count; i++)
        {
            float posX = i * 2f; //綺麗に整列させる
            list[i].transform.localPosition = new Vector2(posX, 0);
        }
    }
}

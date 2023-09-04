using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    List<Card> list = new List<Card>();

    //listに追加して自分の子要素にする
    public void Add(Card card)
    {
        list.Add(card);
        card.transform.SetParent(this.transform); //親として自分自身を子要素にする
    }
    public void Remove(Card card)
    {
        list.Remove(card);
    }

    //手札を整理する
    public void ResetPosition() //手札のカードを整列させる
    {
        //小さい順に並べる
        list.Sort((card0, card1) => card0.Base.CardNumber - card1.Base.CardNumber);

        for (int i = 0; i < list.Count; i++)
        {
            float posX = i * 2f; //綺麗に整列させる
            list[i].transform.localPosition = new Vector2(posX, 0);
        }
    }
    public Card RandomRemove()
    {
        int r = Random.Range(0, list.Count);
        Card card = list[r];
        Remove(card);
        return card;
    }
}
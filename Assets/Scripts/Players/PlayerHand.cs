using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    List<Card> list = new List<Card>();

    //親をPlayerHandにしてカードをその子要素にする
    public void Add(Card card)
    {
        list.Add(card);
        card.transform.SetParent(this.transform); //自分自身を子要素にする
    }
    //指定されたカードを削除する
    public void Remove(Card card)
    {
        list.Remove(card);
    }

    //手札を整理する
    public void ResetPosition() 
    {
        //小さい順に並べる
        list.Sort((card0, card1) => card0.Base.CardNumber - card1.Base.CardNumber);
        for (int i = 0; i < list.Count; i++)
        {
            float posX = i * 2f; //綺麗に整列させる
            list[i].transform.localPosition = new Vector2(posX, 0);
        }
    }
    //敵がランダムにカードを出すためのメソッド
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
    //手札を削除し新しくカードを追加する
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
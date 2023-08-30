using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
  List<Card> list = new List<Card>();

    //list‚É’Ç‰Á‚µ‚ÄŽ©•ª‚ÌŽq—v‘f‚É‚·‚é
    public void Add(Card card)
    {
        list.Add(card);
        card.transform.SetParent(this.transform); //e‚Æ‚µ‚ÄŽ©•ªŽ©g‚ðŽq—v‘f‚É‚·‚é
    }
    public void Remove(Card card)
    {
        list.Remove(card);
    }

    //ŽèŽD‚ð®—‚·‚é
    public void ResetPosition() //ŽèŽD‚ÌƒJ[ƒh‚ð®—ñ‚³‚¹‚é
    {
        //¬‚³‚¢‡‚É•À‚×‚é
        list.Sort((card0, card1) => card0.Base.CardNumber - card1.Base.CardNumber);

        for (int i = 0; i < list.Count; i++)
        {
            float posX = i * 2f; //ãY—í‚É®—ñ‚³‚¹‚é
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

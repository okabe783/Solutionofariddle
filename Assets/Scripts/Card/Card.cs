using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    //カードUI
    //ゲーム内の処理
    [SerializeField] Text nameText;
    [SerializeField] Image icon;
    [SerializeField] Text descriptionText;
    public void Set(CardBase cardBase)
    {
        nameText.text = cardBase.name;
        icon.sprite = cardBase.Icon1;
        descriptionText.text = cardBase.Description;
    }
}

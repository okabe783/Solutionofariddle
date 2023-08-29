using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Card : MonoBehaviour
{
    //ƒJ[ƒhUI
    //ƒQ[ƒ€“à‚Ìˆ—
    [SerializeField] Text nameText;
    [SerializeField] Image icon;
    [SerializeField] Text descriptionText;
    public CardBase Base { get; private set; }

    //UnityAction‚ÍŠÖ”‚ğ“o˜^‚·‚é
    public UnityAction<Card> OnClickCard;
    public void Set(CardBase cardBase)
    {
        Base = cardBase;
        nameText.text = cardBase.name;
        icon.sprite = cardBase.Icon1;
        descriptionText.text = cardBase.Description;
    }
    public void OnClick()
    {
        OnClickCard?.Invoke(this);
    }
}

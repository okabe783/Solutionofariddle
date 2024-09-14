using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>Buttonの管理する</summary>
public class UIButton : MonoBehaviour,IPointerClickHandler,IPointerDownHandler,IPointerUpHandler
{
    [SerializeField] private TextMeshProUGUI _text;

    [SerializeField] private Color _pressedColor = Color.gray;

    private Color _startColor;

    private Image _image;

    private Action _onClickCallback;
    protected void Awake()
    {
        _image = GetComponent<Image>();
        _startColor = _image.color;
    }

    public void OnClickAddListener(Action action)
    {
        _onClickCallback += action;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _onClickCallback?.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _image.color = _startColor;
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        _image.color = _pressedColor;
    }

    public void SetText(string text)
    {
        _text.text = text;
    }
}
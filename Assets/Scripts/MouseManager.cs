using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public float hoverScale = 0.6f; // マウスを合わせたときの拡大率
    private Vector3 originalScale; // オブジェクトの元のスケール

    private void Start()
    {
        originalScale = transform.localScale; // オブジェクトの元のスケールを保存
    }

    private void OnMouseEnter()
    {
        // マウスがオブジェクトに入ったときの処理
        transform.localScale = originalScale * hoverScale; // 拡大する
    }

    private void OnMouseExit()
    {
        // マウスがオブジェクトから出たときの処理
        transform.localScale = originalScale; // 元のスケールに戻す
    }
}

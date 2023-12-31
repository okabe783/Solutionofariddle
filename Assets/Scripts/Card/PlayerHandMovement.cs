using UnityEngine;
using DG.Tweening;

public class PlayerHandMovement : MonoBehaviour
{
    [SerializeField] private Vector2 _position;
    private void Start()
    {
        StartMove();
    }
    public void StartMove()
    {
        transform.position = _position;
        //0.8秒かけて(2,0)に移動する
        this.transform.DOLocalMove(new Vector2(-5.7f, -3.6f), 0.8f);
    }
}

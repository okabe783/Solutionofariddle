using UnityEngine;
using DG.Tweening;

public class PlayerHandMovement : MonoBehaviour
{
    [SerializeField] private Vector2 _position;
    private void Start()
    {
        StartMove();
        //_position = transform.position;
    }
    public void StartMove()
    {
        transform.position = _position;
        //3秒かけて(2,0)に移動する
        this.transform.DOMove(new Vector2(-5.7f, -3.1f), 1f);
    }
}

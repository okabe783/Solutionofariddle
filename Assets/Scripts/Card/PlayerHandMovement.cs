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
        //0.8•b‚©‚¯‚Ä(2,0)‚ÉˆÚ“®‚·‚é
        this.transform.DOMove(new Vector2(-5.7f, -3.1f), 0.8f);
    }
}

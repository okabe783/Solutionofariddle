using UnityEngine;
using DG.Tweening;

public class PlayerHandMovement : MonoBehaviour
{
    private void Start()
    {
        //3秒かけて(2,0)に移動する
        this.transform.DOMove(new Vector2(-5.7f, -3.1f), 1f);
    }
}

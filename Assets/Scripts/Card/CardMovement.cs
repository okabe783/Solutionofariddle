using UnityEngine;
using DG.Tweening;

public class PlayerHandMovement : MonoBehaviour
{
    private void Start()
    {
        //3�b������(2,0)�Ɉړ�����
        this.transform.DOMove(new Vector2(-5.7f, -3.1f), 1f);
    }
}

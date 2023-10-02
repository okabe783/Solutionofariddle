using UnityEngine;

public class EnemyAnimController : MonoBehaviour
{
    [SerializeField] GameObject _particle;

    public void ChangeAttribute()
    {
        Transform trn = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        Instantiate(_particle, trn.position, Quaternion.identity);
    }
}

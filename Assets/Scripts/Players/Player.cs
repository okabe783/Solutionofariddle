using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] PlayerHand _hand;

    public PlayerHand Hand { get => _hand; }
}

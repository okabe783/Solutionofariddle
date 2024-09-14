using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundButton : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    public void OnClick()
    {
        _audioSource.Play();
    }
}

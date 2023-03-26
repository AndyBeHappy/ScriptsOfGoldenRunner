using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private PlayerMove _playerMove;
    [SerializeField] private PreFinishBehaviour _preFinishBehaviour;
    [SerializeField] private Animator _animator;

    //мое
    [SerializeField] private AudioSource _Rumba;

    void Start()
    {
        _playerMove.enabled = false;
        _preFinishBehaviour.enabled = false;
    }


    public void Play()
    {
        _playerMove.enabled = true;
    }

    public void StartPreFinishBehaviour()
    {
        _playerMove.enabled = false;
        _preFinishBehaviour.enabled = true;
    }

    public void StartFinishBehaviour()
    {
        _preFinishBehaviour.enabled = false;
        _animator.SetTrigger("Dance");
        _Rumba.Play();
    }
}

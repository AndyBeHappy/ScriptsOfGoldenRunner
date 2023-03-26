using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{

    public AudioSource _buttonFinishSound;

    public void ClickFinishSound()
    {
        _buttonFinishSound.Play();
    }
}

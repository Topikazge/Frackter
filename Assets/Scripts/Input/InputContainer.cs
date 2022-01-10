using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputContainer : MonoBehaviour
{
    private InputNotification _inputNotification;

    public InputNotification InputNotification => _inputNotification;

    private void Awake()
    {
        _inputNotification = new InputNotification();
    }

    private void OnDisable()
    {
        _inputNotification.Disable();
    }
    private void OnEnable()
    {
        _inputNotification.Enable();
    }
}

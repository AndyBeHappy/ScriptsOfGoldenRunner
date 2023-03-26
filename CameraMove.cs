using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform _target;

    //мое

    [SerializeField] private float X, Y;
    public float sensitivity = 3;


    private void Start()
    {
        transform.parent = null;
    }
    void LateUpdate()
    {
        if (_target)
        {
            transform.position = _target.position;
        }

    }

    //мое

    //private void Update()
    //{
           // X = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
            //X = Mathf.Clamp(X, 120, 250);
           // Y += Input.GetAxis("Mouse Y") * sensitivity;
            //Y = Mathf.Clamp(Y, -40, 30);
           // transform.localEulerAngles = new Vector3(-Y, X, 0);
    //}
}

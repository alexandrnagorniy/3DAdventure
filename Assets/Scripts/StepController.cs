using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepController : MonoBehaviour
{
    public float speed;
    public float sensivity;

    private Transform camera;

    public Joystick moveJoystick;
    public Joystick rotationJoystick;

    // Start is called before the first frame update
    void Start()
    {
        if (GetComponentInChildren<Camera>() != null) camera = GetComponentInChildren<Camera>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (camera != null)
            PlayerMove();
        else
            AIMove();

        if (GetComponent<Rigidbody>().angularVelocity.y != 0f)
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }

    void PlayerMove() 
    {
        float _mouseX = /*Input.GetAxis("Mouse X")*/ rotationJoystick.Horizontal;
        float _mouseY = /*Input.GetAxis("Mouse Y")*/ rotationJoystick.Vertical;

        float _horizontal = /*Input.GetAxis("Horizontal")*/ moveJoystick.Horizontal;
        float _vertical = /*Input.GetAxis("Vertical")*/ moveJoystick.Vertical;

        camera.rotation = Quaternion.Euler(camera.transform.localEulerAngles.x - _mouseY * sensivity, transform.localEulerAngles.y, 0);
        transform.rotation = Quaternion.Euler(0, transform.localEulerAngles.y + _mouseX * sensivity, 0);

        transform.Translate(speed * Time.deltaTime * (Vector3.right * _horizontal + Vector3.forward * _vertical));
    }

    void AIMove() 
    {
    
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMain : MonoBehaviour
{
    public float maxSpeed;
    public float curSpeed;

    public bool isActivate;

    private GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponentInChildren<Camera>().gameObject;
        camera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isActivate)
        {
            camera.SetActive(true);
        }
        else 
        {
            camera.SetActive(false);
        }
    }

    public void EnterInCar() 
    {
        isActivate = true;
    }

    public void ExitInCar() 
    {
        isActivate = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;

    public Transform camera;

    public GameObject Car { get { return car; } set { } }

    private GameObject car;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponentInChildren<Camera>().transform;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Car") 
        {
            if (UIController.Instance.carButton.activeSelf == false)
                UIController.Instance.carButton.SetActive(true);

            car = collision.gameObject;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Car")
        {
            if (UIController.Instance.carButton.activeSelf == true)
                UIController.Instance.carButton.SetActive(false);

            car = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //RaycastHit hit;
        //// Does the ray intersect any objects excluding the player layer
        //if (Physics.Raycast(camera.forward, camera.forward, out hit, 2f))
        //{

        //    Debug.DrawRay(camera.position, camera.forward+ camera.forward, Color.green);
        //    if (hit.transform.tag != "Player")
        //    {
        //        if (hit.transform.tag == "Car")
        //        {
        //            if (UIController.Instance.carButton.activeSelf == false)
        //                UIController.Instance.carButton.SetActive(true);
        //            Debug.DrawRay(camera.position, camera.forward, Color.green);
        //            Debug.Log("Did Hit");
        //        }
        //        else
        //        {
        //            if (UIController.Instance.carButton.activeSelf == true)
        //                UIController.Instance.carButton.SetActive(false);
        //            Debug.DrawRay(camera.position, camera.forward, Color.red);
        //            Debug.Log("Did not Hit");
        //        }
        //    }
        //}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController Instance;
    private PlayerController pc;
    //private 

    [Header("Car UI")]
    public GameObject carUI;
    public GameObject move;
    public GameObject breake;


    [Header("Step UI")]
    public GameObject stepUI;
    public GameObject runButton;
    public GameObject carButton;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;

        carButton.SetActive(false);
        runButton.GetComponent<Image>().color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnterToCar() 
    {
        GameObject _car = PlayerController.Instance.Car;
        _car.GetComponent<CarMain>().EnterInCar();
        PlayerController.Instance.gameObject.SetActive(false);
        stepUI.SetActive(false);
        carUI.SetActive(true);
    }

    public void ExitFromCar() 
    {
        
    }

    public void ShowCarButton() 
    {
        carButton.SetActive(!carButton.activeSelf);
    }

    public void RunButton() 
    {
        if (runButton.GetComponent<Image>().color == Color.green)
            runButton.GetComponent<Image>().color = Color.red;
        else
            runButton.GetComponent<Image>().color = Color.green;
    }
}

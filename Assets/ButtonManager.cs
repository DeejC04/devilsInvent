using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button StartButton;
    public Button A1;
    public Button A2;
    public Button A3;
    public Button B1;
    public Button B2;
    public Button B3;
    public Button R1;
    public Button R2;
    public Button R3;
    public Button F1;
    public Button E1;
    
    public Button Code;


    private void Awake()
    {
        StartButton.gameObject.SetActive(true);
        A1.gameObject.SetActive(false);
        A2.gameObject.SetActive(false);
        A3.gameObject.SetActive(false);
        B1.gameObject.SetActive(false);
        B2.gameObject.SetActive(false);
        B3.gameObject.SetActive(false);
        R1.gameObject.SetActive(false);
        R2.gameObject.SetActive(false);
        R3.gameObject.SetActive(false);
        F1.gameObject.SetActive(false);
        E1.gameObject.SetActive(false);
        Code.gameObject.SetActive(false);
    }

}
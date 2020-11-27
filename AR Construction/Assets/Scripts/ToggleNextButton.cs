using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleNextButton : MonoBehaviour
{
    public Button Btn;
    public Toggle Toggle1;
    public Toggle Toggle2;
    public Toggle Toggle3;
    public Toggle Toggle4;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ToggleSwitch()
    {
        if (Toggle1.isOn && Toggle2.isOn && Toggle3.isOn && Toggle4.isOn)
            Btn.gameObject.SetActive(true);
        else
            Btn.gameObject.SetActive(false);
    }
}

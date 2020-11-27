using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonChanger : MonoBehaviour
{
    public GameObject colorButton;
    public GameObject MyImage;
    public GameObject MyImage2;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = colorButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);


    }

    // Update is called once per frame
    void TaskOnClick()
    {
    
        if (MyImage.GetComponent<Image>().color == new Color32(255, 255, 255, 255))
        {
            MyImage.GetComponent<Image>().color = new Color32(255, 255, 255, 20);
            MyImage2.GetComponent<Image>().color = new Color32(255, 255, 255, 20);
        }

        else
        {
            MyImage.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            MyImage2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }


    }
}
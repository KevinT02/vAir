using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class  MenuManager : MonoBehaviour
{
    public GameObject optionsMenu;
    public GameObject menuButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = menuButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void TaskOnClick()
    {
        optionsMenu.gameObject.SetActive(!optionsMenu.gameObject.activeSelf);
    }
}

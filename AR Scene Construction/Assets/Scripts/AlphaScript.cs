using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AlphaScript : MonoBehaviour
{
    public Material mater;
    //public Renderer rend;
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
        if (mater.color.a == 0.01f)
            ChangeAlphavalue(mater, 1f);
        else
            ChangeAlphavalue(mater, 0.01f);


    }


    void ChangeAlphavalue(Material mat, float alphaval)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaval);
        mat.SetColor("_Color", newColor);
    }
}
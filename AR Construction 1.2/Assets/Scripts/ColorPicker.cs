using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ColorPicker : MonoBehaviour
{
    public GameObject colorButton;

    public Material[] BodyColorMat;
    Material CurrMat;
    Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {


        Button btn = colorButton.GetComponent<Button>();
        Renderer[] renderers = transform.GetComponentsInChildren<Renderer>();

        foreach (var r in renderers)
        {
            r.sharedMaterial = BodyColorMat[0];
            CurrMat = r.sharedMaterial;
        }
        btn.onClick.AddListener(TaskOnClick);



    }

    // Update is called once per frame
    void TaskOnClick()
    {
        Renderer[] renderers = transform.GetComponentsInChildren<Renderer>();

        foreach (var r in renderers)
        {
            r.sharedMaterial = r.sharedMaterial == BodyColorMat[1]
            ? BodyColorMat[0]
            : BodyColorMat[1];
            CurrMat = r.sharedMaterial;
        }

        
    }
}
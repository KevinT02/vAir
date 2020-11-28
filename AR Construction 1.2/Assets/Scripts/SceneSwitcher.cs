using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void TutorialVideo1()
    {
        SceneManager.LoadScene(1);
    }
    public void TutorialSelect()
    {
        SceneManager.LoadScene(0);
    }
    public void OnSiteOffSite()
    {
        SceneManager.LoadScene(2);
    }
    public void OnSiteWarning()
    {
        SceneManager.LoadScene(3);
    }
    public void OffSiteWarning()
    {
        SceneManager.LoadScene(4);
    }
    public void FrenchTutoralSelect()
    {
        SceneManager.LoadScene(5);
    }
    public void FrenchOnSiteOffSite()
    {
        SceneManager.LoadScene(6);
    }
    public void MainScreen()
    {
        SceneManager.LoadScene(7);
    }
    public void Setting()
    {
        SceneManager.LoadScene(8);
    }
    public void TutorialVideo2()
    {
        SceneManager.LoadScene(9);
    }
    public void FrenchOnsiteWarning()
    {
        SceneManager.LoadScene(10);
    }
    public void FrenchMainScreen()
    {
        SceneManager.LoadScene(11);
    }
    public void FrenchOffsiteWarning()
    {
        SceneManager.LoadScene(12);
    }
    public void FrenchTutorialVideo1()
    {
        SceneManager.LoadScene(13);
    }
    public void FrenchTutorialVideo2()
    {
        SceneManager.LoadScene(14);
    }
    public void FrenchSettings()
    {
        SceneManager.LoadScene(15);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMovment : MonoBehaviour
{
    public void ToLevel1()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void ToLevel2()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void ToLevel3()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void ToLevel4()
    {
        SceneManager.LoadSceneAsync(4);
    }
    public void ToLevel5()
    {
        SceneManager.LoadSceneAsync(5);
    }
}

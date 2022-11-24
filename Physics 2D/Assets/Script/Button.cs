using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void Home()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Map1()
    {
        SceneManager.LoadScene("Play1");
    }
    
    public void Map2()
    {
        SceneManager.LoadScene("Play2");
    }
    
    public void Map3()
    {
        SceneManager.LoadScene("Play3");
    }
    
    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    
    
    public void Credit1()
    {
        SceneManager.LoadScene("Credit");
    }

    public void Quit()
    {
        Application.Quit();
    }
}

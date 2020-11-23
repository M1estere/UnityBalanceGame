using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void toFirstLevel()
    {
        SceneManager.LoadScene("Level1");
    }
    public void toSecond()
    {
        SceneManager.LoadScene("");
    }
    public void toThird()
    {
        SceneManager.LoadScene("");
    }
    public void toSettings()
    {
        SceneManager.LoadScene("SettingsScene");
    }
    public void exitGame()
    {
        Application.Quit();
    }
}

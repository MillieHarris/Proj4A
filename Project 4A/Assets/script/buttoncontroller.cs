using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttoncontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void begin()
    { SceneManager.LoadScene("SampleScene"); }

    public void scores()
    { SceneManager.LoadScene("highscores"); }

    public void options()
    { SceneManager.LoadScene("Options"); }

    public void title()
    { SceneManager.LoadScene("Title"); }

    public void lose()
    { SceneManager.LoadScene("endscreen"); }

    public void quit()
    {
        Application.Quit();
    }

}

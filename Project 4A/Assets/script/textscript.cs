using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class textscript : MonoBehaviour
{

    public Text timetxt;
    public float time;
    public Text scoretxt;
    public int lives;
    public float score;
    public Text livestxt;
    

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject lifescript = GameObject.Find("Player");
        enemycollision script = lifescript.GetComponent<enemycollision>();

        livestxt.text = "Lives: " + lives;


        time += Time.deltaTime;
        timetxt.text = "" + time;

        score = time * 100f;

        scoretxt.text = "Score: " + score;

        PlayerPrefs.SetFloat("score", score);

        if (lives == 0)
        { SceneManager.LoadScene("endscreen"); }



    }
}

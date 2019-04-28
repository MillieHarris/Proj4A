using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endgamescore : MonoBehaviour
{
    public Text finalscore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        finalscore.text = "Final Score: " + PlayerPrefs.GetFloat("score");
    }
}

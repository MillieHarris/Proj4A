using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincollision : MonoBehaviour
{

    public ParticleSystem coinget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject scorescript = GameObject.Find("Canvas");
        textscript script = scorescript.GetComponent<textscript>();


        if (collision.gameObject.tag == "coin")
        { script.score += 40;
            coinget.Play();
            Destroy(collision.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemycollision : MonoBehaviour
{
    public GameObject player;
    public bool isActive = false;
    public float countdown = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive == true && countdown >= 0)
        { countdown -= 1 * Time.deltaTime;

        }

        if (countdown < 0)
        { isActive = false;
            countdown = 2;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject lifescript = GameObject.Find("Canvas");
        textscript script = lifescript.GetComponent<textscript>();

        if (collision.gameObject.tag == "enemy" && isActive == false)
        { script.lives -= 1;
            isActive = true;


         //   player.transform.position = new Vector3(player.transform.position.x - 3, player.transform.position.y, player.transform.position.z);
        }


        if (collision.gameObject.tag == "doghouse")
        { SceneManager.LoadScene("winscreen"); }

    }


}

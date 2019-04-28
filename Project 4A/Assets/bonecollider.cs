using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonecollider : MonoBehaviour
{
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
        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "enemykillcollide")
        { Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "platform")
        { Destroy(this.gameObject); }

        if (collision.gameObject.tag == "bottom")
        { Destroy(this.gameObject); }

    }

}

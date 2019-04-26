using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killpostman : MonoBehaviour
{
    public GameObject postmanparent;
    public GameObject postman;
    public float min;
    public float max;



    // Start is called before the first frame update
    void Start()
    {
        min = postman.transform.position.x;
        max = postman.transform.position.x + 6;
    }

    // Update is called once per frame
    void Update()
    {
        postman.transform.position = new Vector3(Mathf.PingPong(Time.time * 5, max - min) + min, postman.transform.position.y, postman.transform.position.z);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "dog")
        {
            GameObject lifescript = GameObject.Find("Canvas");
            textscript script = lifescript.GetComponent<textscript>();


            Destroy(postmanparent);
            Destroy(this.gameObject);
            script.score += 100;


        }
    }
}

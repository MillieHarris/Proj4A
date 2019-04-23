using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepostman : MonoBehaviour
{
    public GameObject postman;
    public Rigidbody2D postbody;
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
}

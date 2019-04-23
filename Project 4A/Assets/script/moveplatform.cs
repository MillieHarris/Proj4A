using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplatform : MonoBehaviour
{
    public GameObject platform;
    public float min;
    public float max;
    public float min2;
    public float max2;
    public float min3;
    public float max3;
    public float min4;
    public float max4;
    public float min5;
    public float max5;
    public float min6;
    public float max6;
    public GameObject platform2;
    public GameObject platform3;
    public GameObject platformupdown;
    public GameObject platform4;
    public GameObject updown2;

    // Start is called before the first frame update
    void Start()
    {
        min = platform.transform.position.x;
        max = platform.transform.position.x + 6;

        min2 = platform2.transform.position.x;
        max2 = platform2.transform.position.x + 6;
        
        min3 = platform3.transform.position.x;
        max3 = platform3.transform.position.x + 6;

        min4 = platformupdown.transform.position.y;
        max4 = platformupdown.transform.position.y + 10;

        min5 = platform4.transform.position.x;
        max5 = platform4.transform.position.x + 6;

        min6 = updown2.transform.position.y;
        max6 = updown2.transform.position.y + 7;


    }

    // Update is called once per frame
    void Update()
    {
         platform.transform.position = new Vector3(Mathf.PingPong(Time.time * 5, max - min) + min, platform.transform.position.y, platform.transform.position.z); 

         platform2.transform.position = new Vector3(Mathf.PingPong(Time.time * 5, max2 - min2) + min2, platform2.transform.position.y, platform2.transform.position.z);

        platform3.transform.position = new Vector3(Mathf.PingPong(Time.time * 5, max3 - min3) + min3, platform3.transform.position.y, platform3.transform.position.z);

        platformupdown.transform.position = new Vector3(platformupdown.transform.position.x, Mathf.PingPong(Time.time * 5, max4 - min4) + min4, platformupdown.transform.position.z);

        platform4.transform.position = new Vector3(Mathf.PingPong(Time.time * 5, max5 - min5) + min5, platform4.transform.position.y, platform4.transform.position.z);

        updown2.transform.position = new Vector3(updown2.transform.position.x, Mathf.PingPong(Time.time * 8, max6 - min6) + min6, updown2.transform.position.z);


    }
}

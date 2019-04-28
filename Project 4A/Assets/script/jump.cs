using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jump : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public bool onGround;
    public Rigidbody2D playerbody;
    public float jumpspeed;
    public Animator jumper;
    public AudioSource jumpsound;
    public AudioClip jumpclip;
    public int haspower;
    public GameObject boneprefab;
    public int rotation;
    public bool isRight;
    

    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
        jumpspeed = 4000f;
        haspower = 0;
        rotation = 60;

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey("d"))
        { player.transform.position += Vector3.right * speed * Time.deltaTime;
            SpriteRenderer playsprite = player.GetComponent<SpriteRenderer>();
            playsprite.flipX = false;
            isRight = true;

        }
        
        if (Input.GetKey("a"))
        {
            SpriteRenderer playsprite = player.GetComponent<SpriteRenderer>();
            player.transform.position += Vector3.left * speed * Time.deltaTime;
            playsprite.flipX = true;
            isRight = false;
        }

        if (Input.GetKeyDown("w") && onGround)
        {
            jumper.SetInteger("animstate",1);
          //  player.transform.Translate(Vector3.up * 260 * Time.deltaTime);
            playerbody.AddForce(Vector3.up * jumpspeed);
            jumpsound.PlayOneShot(jumpclip);
        }

        if(onGround)
        { player.transform.Rotate(0,0,0)  ;
            playerbody.gravityScale = 10;
        }

        if (onGround == false)
        { playerbody.gravityScale = 1; }



        if (Input.GetKeyDown("space") && haspower == 1 && isRight == true)
        { GameObject boneinstance = Instantiate(boneprefab, player.transform.position, Quaternion.identity );
            Rigidbody2D bonebody = boneinstance.GetComponent<Rigidbody2D>();
            bonebody.AddForce(Vector3.right * 600);
            bonebody.transform.rotation = Quaternion.Euler(0, 0, 90);
            jumper.SetInteger("animstate", 2);
        }

        if (Input.GetKeyDown("space") && haspower == 1 && isRight == false)
        {
            GameObject boneinstance = Instantiate(boneprefab, player.transform.position, Quaternion.identity);
            Rigidbody2D bonebody = boneinstance.GetComponent<Rigidbody2D>();
            bonebody.AddForce(Vector3.left * 600);
            bonebody.transform.rotation = Quaternion.Euler(0, 0, 90);
            jumper.SetInteger("animstate", 2);
        }

        if (haspower == 1)
        { SpriteRenderer playersprite = player.GetComponent<SpriteRenderer>();
            playersprite.color = Color.green;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "platform")
        { onGround = true;
            jumper.SetInteger("animstate", 0);
        }


        if (collision.gameObject.tag == "bottom")
        { SceneManager.LoadScene("endscreen"); }


        if (collision.gameObject.tag == "power")
        { haspower = 1; }

        if (collision.gameObject.tag == "enemy")
        { haspower = 0;
            jumper.SetInteger("animstate", 3);
            SpriteRenderer playersprite = player.GetComponent<SpriteRenderer>();
            playersprite.color = Color.white;
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "platform")
        { onGround = false;
          playerbody.velocity = player.transform.position * 0f;
        }
    }
}

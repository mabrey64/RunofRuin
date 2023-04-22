using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_Enemy : MonoBehaviour
{
    [SerializeField] private LayerMask platformsLayerMask;
    private Rigidbody2D rib;
    float fallingSpeed = 50f;
    float risingSpeed = 2f;
    float length = 3f;
    public GameObject thowp;
    public Vector2 startPosition;
    private BoxCollider2D boxCollider2D;
    private Collider2D coll;
    private bool GoUP;

    void Start()
    { 
        rib = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    public void GoDown ()
    { 
        startPosition= transform.position;
        rib.velocity = Vector2.down * fallingSpeed;
/*        if (startPosition !== transform.position)
        {
            rib.velocity = Vector2.up * fallingSpeed;
        }*/
        /*float y = transform.position.y + Mathf.PingPong(Time.time * fallingSpeed, length);
        Vector2 pos = new Vector2(transform.position.x, y);*/
    }

    void Update()
    {
        if (GoUP)
        {
            if (transform.position.y < startPosition.y)
            {
                //rib.velocity = Vector2.up * risingSpeed;
                //rib.gravityScale = 0f;
                rib.transform.Translate(Vector2.up * Time.deltaTime);
            }
            else
            {
                GoUP= false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.name == "Ground")
        {
            GoUP= true;
        }
    }


}

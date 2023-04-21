using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_Enemy : MonoBehaviour
{
    [SerializeField] private LayerMask platformsLayerMask;
    private Rigidbody2D rib;
    float fallingSpeed = 50f;
    float length = 3f;
    public GameObject thowp;
    public Vector2 startPosition;
    private BoxCollider2D boxCollider2D;
    private Collider2D coll;

    void Start()
    { 
        rib = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    public void DownthenUp ()
    { 
        rib.gravityScale= 1.0f;
        /*rib.velocity = Vector2.down * fallingSpeed;
        if (startPosition !== transform.position)
        {
            rib.velocity = Vector2.up * fallingSpeed;
        }*/
        /*float y = transform.position.y + Mathf.PingPong(Time.time * fallingSpeed, length);
        Vector2 pos = new Vector2(transform.position.x, y);*/

        if (IsGrounded())
        {
            rib.gravityScale= -1.0f;
        }
    }

    private bool IsGrounded()
    {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, 1f, platformsLayerMask);
        return raycastHit2D.collider != null;
    }
}

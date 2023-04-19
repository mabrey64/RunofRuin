using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private LayerMask platformsLayerMask;
    private Rigidbody2D rib;
    float fallingSpeed = 50f;
    public GameObject thowp;
    public Vector2 startPosition;
    private BoxCollider2D boxCollider2D;
    private Collider2D coll;

    void DownthenUp ()
    {
        rib.velocity = new Vector2(fallingSpeed, rib.velocity.x);
        startPosition = transform.position;
       /* if (startPosition !== transform.position)
        {
            rib.velocity = Vector2.up * fallingSpeed;
        }*/
    }
}

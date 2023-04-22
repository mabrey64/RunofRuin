using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Experimental.GraphView.GraphView;

public class KillZone : MonoBehaviour
{
    public GameObject player;
    public Transform respawnPoint;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            Debug.Log("You were killed...");
            player.transform.position = respawnPoint.position;
        }
    }


}

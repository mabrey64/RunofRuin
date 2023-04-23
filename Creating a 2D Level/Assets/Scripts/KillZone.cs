using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Experimental.GraphView.GraphView;

public class KillZone : MonoBehaviour
{
    public GameObject player;
    public Transform respawnPoint;
    private Death_Manager dm;

    private void Awake()
    {
        dm = gameObject.GetComponent<Death_Manager>();
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            player.transform.position = respawnPoint.position;
            dm.IncreaseDeaths();
        }
    }


}

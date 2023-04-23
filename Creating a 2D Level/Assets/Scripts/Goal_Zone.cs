using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_Zone : MonoBehaviour
{
    [SerializeField] private GameObject _winScreen;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            player.SetActive(false);
            _winScreen.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

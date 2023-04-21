using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractZone : MonoBehaviour
{
    public GameObject _thowp;
    private Falling_Enemy _downthenup;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "Player")
        {
            _downthenup = _thowp.GetComponent<Falling_Enemy>();
            _downthenup.DownthenUp();
            Debug.Log("Player has moved into Interact Zone.");
        }
    }
}

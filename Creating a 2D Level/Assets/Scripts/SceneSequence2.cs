using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSequence2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().name == "OpeningPt2") 
        {
            StartCoroutine(Sequence());
        }
    }

    IEnumerator Sequence()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

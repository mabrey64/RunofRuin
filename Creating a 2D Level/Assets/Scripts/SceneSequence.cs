using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSequence : MonoBehaviour
{
    private bool isDone = false;

    void Start()
    {
        SceneManager.GetActiveScene();
        StartCoroutine(Sequence());
    }

    IEnumerator Sequence()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(1);
    }
}

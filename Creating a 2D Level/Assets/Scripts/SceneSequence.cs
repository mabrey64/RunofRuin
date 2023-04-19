using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSequence : MonoBehaviour
{
    public bool isDone = false;

    void Start()
    {
        SceneManager.GetActiveScene();
        StartCoroutine(Sequence());
        if (isDone == true)
        {
            StartLevel();
        }
    }

    void StartLevel()
    {
        StartCoroutine(StartGame());
    }

    IEnumerator Sequence()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(1);
        isDone = true;
    }
    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(2);
    }

}

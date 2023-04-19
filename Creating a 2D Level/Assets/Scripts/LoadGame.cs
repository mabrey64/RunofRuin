using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    
    public string myScene = "";

    public void LoadLevel()
    {
        SceneManager.LoadScene(myScene);
    }
}

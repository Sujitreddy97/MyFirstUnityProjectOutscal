using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
   
    public string[] sceneName = new string[3];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClickEvent(int i)
    {
        SceneManager.LoadScene(sceneName[i]);
    }
}

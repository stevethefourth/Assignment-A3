using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loadScene1()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadSceneAsync(1);
        SceneManager.sceneLoaded += OnSceneLoaded;
        

    }

    public void loadScene2()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadSceneAsync(2);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {

    }
}

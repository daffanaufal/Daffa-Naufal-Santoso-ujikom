using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public GameObject jeda;

    public void Start()
    {
    }

    public void Update()
    {
        pause();
    }
    public void pause()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("pause");
            Time.timeScale = 0;
            jeda.SetActive(true);
        }
    }
    
    public void resume()
    {
        Time.timeScale = 1;
        jeda.SetActive(false);

    }
    public void exit()
    {
        SceneManager.LoadScene("Main Menu");

    }
}

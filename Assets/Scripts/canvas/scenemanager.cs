using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{

    public void masuk()
    {
        SceneManager.LoadScene("Main Stage");
        Time.timeScale = 1;
    }

    public void keluar()
    {
        Application.Quit();
    }

}

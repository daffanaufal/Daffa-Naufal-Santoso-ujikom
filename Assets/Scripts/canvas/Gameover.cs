using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Gameover : MonoBehaviour
{
    public GameObject GO;
    private Characteranimation player_anim;

    void Awake()
    {
        player_anim = GetComponentInChildren<Characteranimation>();
    }

    public void Start()
    {
     //if(Time.....)
     //   {
      //      gameover();
      //  }
    }

    private void Update()
    {
       
    }

    void gameover()
    {
       
        Debug.Log("game over");
        GO.SetActive(true);
        
    }
    public void score()
    {

    }
    public void retry()
    {
        SceneManager.LoadScene("Main Stage");
        Time.timeScale = 1;
        GO.SetActive(false);

    }
    public void exit()
    {
        SceneManager.LoadScene("Main Menu");

    }
}

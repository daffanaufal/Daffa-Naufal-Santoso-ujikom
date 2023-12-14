using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charamovement : MonoBehaviour
{
    private Characteranimation player_anim;
    public float kecepatan = 5f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        jalan();
        lempar();
    }

    void Awake()
    {
        player_anim = GetComponentInChildren<Characteranimation>();
    }
    void jalan()
    {
        float horizontal = Input.GetAxisRaw("Horizontal") ;

               Vector3 gerakan = new Vector3(horizontal, 0f) * kecepatan * Time.deltaTime;
        transform.Translate(gerakan);
        player_anim.left();
    }
    void lempar()
    {
        if(Input.GetKey(KeyCode.Space)||Input.GetKey(KeyCode.Mouse0))
            {
            Debug.Log("lempar");
            player_anim.lempar();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersoController : MonoBehaviour
{

    private Animator Anim;
    public float TurnSpeed = 50;
    public bool Key = false;

    // Use this for initialization
    void Start()
    {

        Anim = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        //Avancer Marche
        float vertical = Input.GetAxis("Vertical");
        Anim.SetFloat("Walk", vertical);

        //Tourner sur lui meme
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, 1, 0), Time.deltaTime * TurnSpeed * horizontal);

        //Sauter
        float jump = Input.GetAxis("Jump");
        Anim.SetFloat("Jump", jump);

        //Prendre
        if (Input.GetAxis("Submit") == 1 && Key == true)
        {
            Anim.SetTrigger("Pick");
        }

       

    }
}
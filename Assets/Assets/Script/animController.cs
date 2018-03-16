using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animController : MonoBehaviour {

    public float speed = 3f;
    public int coefRot = 60;
    private Animator anim;


	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
     {
         
       transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * coefRot * Time.deltaTime);
  

        //animation de marche
        print(Input.GetAxis("Vertical"));
        if (Input.GetAxis("Vertical") > 0)
        {
            anim.SetBool("Running", true);
        }
        else
        {
            anim.SetBool("Running", false);
        }
    }
}

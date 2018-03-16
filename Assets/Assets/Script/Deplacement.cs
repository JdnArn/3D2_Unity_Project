using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{

    public float VitesseMarche = 3f;
    private Animator anim;
    bool CanJump = true;
    public float TurnSpeed = 40;


    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            //MarcheAvant
            anim.SetBool("Running", true);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            //MarcheArrière
            anim.SetBool("RunningBack", true);
        }

        if (Input.GetAxis("Vertical") == 0)
        {
            //Idle
            anim.SetBool("Running", false);
            anim.SetBool("RunningBack", false);
        }

        float horizontal = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, 1, 0), Time.deltaTime * TurnSpeed * horizontal);
        {

        }
        if (Input.GetAxis("Horizontal") == 0)
        {
            //Idle
            anim.SetBool("Right", false);
            anim.SetBool("Left", false);

            //Sauter
            if (Input.GetKey(KeyCode.Space))
            {
                if (CanJump)
                {
                    CanJump = false;
                    StartCoroutine(Jumping());
                }
                else
                {
                    anim.SetBool("Jump", false);
                }

            }
            

        }
    }
    private IEnumerator Jumping()
    {
        Debug.Log("saute");
        anim.SetTrigger("Jump");
        yield return new WaitForSeconds(0f);
        CanJump = true;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCollor : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        rend.sharedMaterial = material[0];



    }
    IEnumerator ExecuteAfterTimes(float time)
    {
        yield return new WaitForSeconds(time);
        rend.sharedMaterial = material[1];



    }



    // Use this for initialization
    void Start()

    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Akai")


        {
           
            rend.sharedMaterial = material[1];
            
            StartCoroutine(ExecuteAfterTime(1));
            
        }

    }
}

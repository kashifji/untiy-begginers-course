using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "zombie")
        {

            Animator anim = col.gameObject.GetComponent<Animator>();
            anim.SetBool("attack", true);
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "zombie")
        {

            Animator anim = col.gameObject.GetComponent<Animator>();
            anim.SetBool("attack", false);
        }
    }
}

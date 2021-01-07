using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptcollide : MonoBehaviour
{
    AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        audiosource.Play();
    }
}

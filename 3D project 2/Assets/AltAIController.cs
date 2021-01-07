using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltAIController : MonoBehaviour
{
    public GameObject[] waypints;
    Vector3 target;
    int currentWP = 0;



    // Start is called before the first frame update
    void Start()
    {
        target = waypints[currentWP].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float Distance = Vector3.Distance(target, this.transform.position);
        Vector3 Direction = target - this.transform.position;
    
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(Direction), Time.deltaTime *5);
        this.transform.Translate(0, 0, 20 * Time.deltaTime);
        if (Distance <= 5)
        {
            if (currentWP > waypints.Length)
                currentWP = 0;
            currentWP++;
            target = waypints[currentWP].transform.position;
        }
    }
}


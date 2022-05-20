using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToriController : MonoBehaviour
{
    public float posMAX,posmin,sokudo;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= posMAX)
        {
            sokudo *= -1;
        }
        if(transform.position.y <= posmin)
        {
            sokudo *= -1;
        }
        transform.Translate(0, sokudo, 0);
    }
}

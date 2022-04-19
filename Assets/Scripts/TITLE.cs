using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TITLE : MonoBehaviour
{
    public GameObject U;
    public GameObject U2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Destroy(U);
            Instantiate(U2, U.transform.position, U.transform.rotation);
        }
    }
}

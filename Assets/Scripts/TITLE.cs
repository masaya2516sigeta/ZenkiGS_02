using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TITLE : MonoBehaviour
{
    public GameObject U,U2,M,M2,O,O2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)&&U!=null)
        {
            Destroy(U);
            Instantiate(U2, U.transform.position, U.transform.rotation);
            Destroy(M);
            Instantiate(M2, M.transform.position, M.transform.rotation);
            Destroy(O);
            Instantiate(O2, O.transform.position, O.transform.rotation);
        }
    }
}

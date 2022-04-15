using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObj2 : MonoBehaviour
{
    public GameObject ChangeObject1;
    bool CircleCheck = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CircleCheck == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                GameObject obj = Instantiate(ChangeObject1);
                obj.transform.position = this.transform.position;
                Destroy(this.gameObject,0.1f);

            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "circle")
        {
            CircleCheck = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "circle")
        {
            CircleCheck = false;
        }
    }
}

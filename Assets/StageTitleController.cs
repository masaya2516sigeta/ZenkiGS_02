using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageTitleController : MonoBehaviour
{
    public Text text;
    bool TriggerON = false;
    bool TriggerOFF = false;
    bool TimeTrigger = false;
    float Time = 0;
    float z = 0;
    // Start is called before the first frame update
    void Start()
    {
        //text.GetComponent<Color>();
        text.color = new Color(1, 1, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(TimeTrigger == true)
        {
            Time += 0.01f ;
            if(Time >= 3)
            {
                TimeTrigger = false;
                Time = 0;
                TriggerOFF = true;
            }
        }
        if(TriggerON == true)
        {
            z += 0.03f;
            text.color = new Color(1, 1, 1, z);
            if (z >= 1)
            {
                TriggerON = false;
                TimeTrigger = true;
            }
        }
        if(TriggerOFF == true)
        {
            z -= 0.03f;
            text.color = new Color(1, 1, 1, z);
            if (z <= 0)
            {
                TriggerOFF = false;
                
            }
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        TriggerON = true;
    }
}

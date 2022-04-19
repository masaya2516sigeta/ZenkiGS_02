using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class White : MonoBehaviour
{
    SpriteRenderer Sr; //コンポーネント取得
    public static bool WhiteOn = false;
    float z = 1;
    // Start is called before the first frame update
    void Start()
    {
        Sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(en.WhiteCheck == true)
        {
            
            if (Input.GetKeyDown(KeyCode.Return))
            {
                
                Sr.color = new Color(1, 1, 1, 255);
                WhiteOn = true;
            }
        }
        if(WhiteOn == true)
        {
            z -= 0.05f;
            Sr.color = new Color(1, 1, 1, z);
            if (z <= 0)
            {
                WhiteOn = false;
                z = 1;
            }
        }
    }
    
}

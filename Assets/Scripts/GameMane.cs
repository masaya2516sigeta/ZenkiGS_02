using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMane : MonoBehaviour
{
    public static float WX= -39.56694f, WY=10.6f;
    public static bool changeOn = false;
    public static bool SceneCheck = false;
    //public static GameObject CheckPoint;
    public GameObject chara;
    
    // Start is called before the first frame update
    void Start()
    {
        var pos = chara.transform.position;
        pos.x = WX;
        pos.y = WY;
        chara.transform.position = pos;
        
    }

    // Update is called once per frame
    void Update()
    {
        //print(WX);
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneCheck = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Sceneçƒì«Ç›çûÇ›
        }
    }
}

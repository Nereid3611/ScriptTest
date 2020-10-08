using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] status = { 200, 53, 40, 30, 60 };

            //順方向
        Debug.Log("順方向");
        for (int i = 0; i < status.Length; i++) 
        { Debug.Log(status[i]); }

        //逆方向
        Debug.Log("逆方向");
        for (int i = status.Length - 1 ; i >= 0; i--)
        { Debug.Log(status[i]); }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

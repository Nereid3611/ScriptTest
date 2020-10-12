using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class boss 
{

    public void Attack(int Magicpoint )
    {

            Debug.Log("魔法攻撃をした。残りMPは" + Magicpoint);
        
    }

}
public class test2 : MonoBehaviour
{   
    
    // Start is called before the first frame update
    void Start()
      {
        boss Testboss = new boss ();
        int MP = 53;
        for (int i = MP; i > 5; i -= 5)
        {
            MP -= 5;
            Testboss.Attack(MP);
        }
        Debug.Log("MPが足りないため魔法が使えない。");
      }
}


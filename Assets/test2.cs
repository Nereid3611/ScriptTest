using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class boss 
{
   

    public  int Magic(int MP)
    {

        int usedMP = MP - 5;
        return usedMP;
       
    }


}
public class test2 : MonoBehaviour
{   
    
    // Start is called before the first frame update
    void Start()
      {
        boss Testboss = new boss ();

        int MagicP = 53;

        for (int i = MagicP; i > 5; i -= 5)
        {

            int UsedMP = Testboss.Magic(MagicP);
            MagicP = UsedMP;

            Debug.Log("魔法攻撃をした。残りMPは" + UsedMP);
        }

        Debug.Log("MPが足りないため魔法が使えない。");
    }
}


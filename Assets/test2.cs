using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class boss 
{
    public int MagicP = 53;

    public bool Magic()
    {
        if (MagicP >= 5 )
        {
            MagicP -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + MagicP);
            return true;
            
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
            return false;
        }
        
       
    }


}
public class test2 : MonoBehaviour
{
    private bool MagicAttack = true ;

    boss Testboss = new boss();

    // Start is called before the first frame update
    void Start()
    {
        while (this.MagicAttack == true)
        {
            this.MagicAttack = Testboss.Magic();
        }

    }



}


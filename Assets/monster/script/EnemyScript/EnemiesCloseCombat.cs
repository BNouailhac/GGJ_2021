using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesCloseCombat : EnemiesAttack
{
    
    public override void Start()
    {
        base.Start();
        //StartCoroutine(HitPlayer());
    }
/*
    void attack()
    {
    	yield return new WaitForSeconds(cooldown);
    //	if (player != null)	{ }
    }
*/
   
    void Update()
    {
        
    }
}

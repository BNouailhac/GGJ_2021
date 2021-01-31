using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	public float health;
	public float maxHealth;
	public float cooldown; //cooldown between hit on the player
	//protected GameObject player;

    void Start()
    {
        health = maxHealth;
    //    player = FindObjectOfType<Player>().gameObject;
    }

    public void takeDamage(float dmg)
    {
    	health -= dmg;
    	isItDead();
    }

    public void isItDead()
    {
    	if (health <= 0) {
    		//Destoy(gameObject);
    	}
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
    /*	if () //player proche
    	{
    		//StartCoroutine("RushPlayer");
    	}
    	else
    	{
    		//StopCoroutine("RushPlayer");/StartCoroutine("Idle");
    	}
    */
    }
}

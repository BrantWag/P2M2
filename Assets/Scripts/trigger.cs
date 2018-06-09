using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
	 //If on exit the tag is either a player, enemy or asteroid it is destroyed 
	void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")//for player 
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Asteroid")//for asteroid 
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Enemy") //for enemy 
        {
            Destroy(other.gameObject);
        }
    }
}
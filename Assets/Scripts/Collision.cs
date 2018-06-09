﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

    // destorys everything other than the DeathZone 
    void OnTriggerExit2D(Collider2D other)
    {
        if ((other.gameObject.tag != "DeathZone") && (other.gameObject.tag != this.tag))
        {
            Destroy(other.gameObject);
        }
    }
}


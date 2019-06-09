using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * 
 * 
 * 
 * 
 */
public class InitializeFight : MonoBehaviour {

    public GameObject Monster;

	// Use this for initialization
	void Start () {
        //health
        mon_control.monsMaxFatigue = StaticMonsterAtt.health;
        //sprite
        Monster.GetComponent<SpriteRenderer>().sprite = StaticMonsterAtt.spritemonster;
        //damage
        mon_control.monsterDamagePower = StaticMonsterAtt.damage;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

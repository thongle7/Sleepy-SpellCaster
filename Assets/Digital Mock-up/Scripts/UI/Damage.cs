using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

    public float damageVal;
    private float wait = 0;

    private PlayerSleep player;
    private SpriteRenderer wizSprite;

    void FixedUpdate()
    {
        if (GameTime.isPaused) return;
        if(player)
        {
            wait += Time.fixedDeltaTime;
            if (wait >= .5)
            {
                wiz_control.wizFatigue += damageVal;
                wait -= 0.5f;
            } 
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        PlayerSleep script = col.GetComponent<PlayerSleep>();
        if (script)
        {
            player = script;
            wiz_control.wizFatigue += damageVal;
            wizSprite = col.GetComponent<SpriteRenderer>();
            wizSprite.color = Color.red;
        }
    }


    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            wait = 0;
            player = null;
            wizSprite.color = Color.white;
        }
    }
}

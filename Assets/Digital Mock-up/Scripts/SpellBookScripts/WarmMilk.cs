using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarmMilk : MonoBehaviour {

    public float damage;

    private PlayerSpells spells;

    void OnTriggerEnter2D(Collider2D col)
    {
        spells = col.GetComponent<PlayerSpells>();
        if (spells)
        {
            wiz_control.warmMilkStock++;
            Destroy(gameObject);
        }
    }
}

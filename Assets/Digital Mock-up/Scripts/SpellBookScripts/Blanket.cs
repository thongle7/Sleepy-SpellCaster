using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Blanket : MonoBehaviour
{

    public float damage;

    private PlayerSpells spells;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        spells = col.GetComponent<PlayerSpells>();
        if (spells)
        {
            wiz_control.blanketStock++;
            Destroy(gameObject);
        }
    }
}

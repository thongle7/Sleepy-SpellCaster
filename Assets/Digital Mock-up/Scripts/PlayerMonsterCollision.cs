using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMonsterCollision : MonoBehaviour {
    public float KnockbackStrength = 3;
    private SpriteRenderer wizSprite;

    void Start()
    {
        wizSprite = GetComponent<SpriteRenderer>();
    }

	
    private void OnCollisionEnter2D(Collision2D collisionData)
    {

        if (collisionData.gameObject.CompareTag("Monster"))
        {
            Vector3 pz = collisionData.gameObject.transform.position;
            pz.z = 0;

            wiz_control.wizFatigue  += collisionData.gameObject.GetComponent<MonsterAttributes>().damageIn;

            Vector3 heading = (transform.position - pz).normalized;
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            GetComponent<Rigidbody2D>().angularVelocity = 0;
            GetComponent<Rigidbody2D>().AddForce(heading * KnockbackStrength, ForceMode2D.Impulse);

            wizSprite.color = Color.red;
        }
    }

    private void OnCollisionExit2D(Collision2D collisionData)
    {
        wizSprite.color = Color.white;
    }
}

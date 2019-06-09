using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boomerangfly_Tutorial : MonoBehaviour {


    public float speed;
    private GameObject player;
    private Vector3 mousepos;
    private Vector3 heading;
    private float flightTime = 1f;
    private float ReturnTime = 0f;
    private bool InPlatform = false;
    private bool MonsterAttached = false;
    private GameObject Monster;
    public static GameObject CombatMonster;
    private Vector3 monsterLocation;
    private SpriteRenderer spriteR;
    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("WizSprite");
        mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousepos.z = 0;
        heading = (mousepos - transform.position).normalized;
        ReturnTime = Time.time + flightTime;
    }

    // Update is called once per frame
    void Update()
    {

        if (MonsterAttached)
        {
            Monster.transform.position = transform.position;
            Vector3 headingBack = (player.transform.position - transform.position).normalized;
            transform.position += headingBack * speed * Time.deltaTime;
            transform.Rotate(Vector3.forward, speed * Time.deltaTime * 60);
            if (Vector3.Distance(transform.position, player.transform.position) < 2.5 ||
                (Vector3.Distance(transform.position, player.transform.position) < 4 && Monster.transform.localScale.x > 1))
            {
                Destroy(this.gameObject);
                GameTime.isPaused = true;

                spriteR = Monster.gameObject.GetComponent<SpriteRenderer>();
                StaticMonsterAtt.spritemonster = spriteR.sprite;
                StaticMonsterAtt.health = Monster.GetComponent<MonsterAttributes>().healthIn;
                StaticMonsterAtt.damage = Monster.GetComponent<MonsterAttributes>().damageIn;

                CombatMonster = Monster;
                SceneManager.LoadScene("Fighting_Tutorial", LoadSceneMode.Additive);
                Monster.transform.position = monsterLocation;
            }

        }
        else if (Time.time >= ReturnTime)
        {
            Vector3 headingBack = (player.transform.position - transform.position).normalized;
            transform.position += headingBack * speed * Time.deltaTime;
            transform.Rotate(Vector3.forward, speed * Time.deltaTime * 60);
            if (Vector3.Distance(transform.position, player.transform.position) < 1)
            {
                Destroy(this.gameObject);
            }
        }
        else
        {
            if (InPlatform)
            {
                ReturnTime = 0;
            }
            transform.Rotate(Vector3.forward, speed * Time.deltaTime * 60);
            transform.position += heading * speed * Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collisionData)
    {
        if (collisionData.gameObject.CompareTag("Platform"))
        {
            InPlatform = true;
        }
        else if (collisionData.gameObject.CompareTag("Monster"))
        {
            Monster = collisionData.gameObject;
            MonsterAttached = true;
            monsterLocation = collisionData.gameObject.transform.position;
        }
    }
}

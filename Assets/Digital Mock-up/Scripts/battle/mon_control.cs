using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mon_control : MonoBehaviour {
    public float monsFatigue;
    public static float monsMaxFatigue;
    public GameObject scene;

    public Transform damageTextObj;
    public Transform attackParticle;

    public static float monsterDamagePower = 10;
    public static bool monsterDefeated = false;
    public Text sleepText;
    public Text monsDieText;
    private float endOfwait = 0f;
    private bool timer = true;

    public static Sprite spritemonster;
    // Use this for initialization
    void Start () {
        spritemonster = GetComponent<SpriteRenderer>().sprite;

    }
	
	// Update is called once per frame
	void Update () {

        sleepText.text = monsFatigue.ToString() + "/" + monsMaxFatigue.ToString();
        // If the monster reach its fatigue level
        // Open winning scene
        if (monsFatigue >= monsMaxFatigue)
        {
            battleFlow.immuneBlanket = false;
            battleFlow.immuneDrain = false;
            battleFlow.immuneLullaby = false;
            monsFatigue = monsMaxFatigue;
            monsDieText.text = "The Monster Has Fallen Asleep";
            if (timer)
            {
                endOfwait = Time.time + 2;
                timer = false;
            }

            if (Time.time >= endOfwait)
            {
                monsterDefeated = true;
                GameTime.isPaused = false;
                Destroy(scene);
            }
        }

        // Add fatigue to the monster
        if (battleFlow.damageDisplay == "y")
        {
            monsFatigue += battleFlow.currentDammage;
            Debug.Log(monsFatigue);
            battleFlow.damageDisplay = "n";
        }

        if ( (battleFlow.whichTurn == 2) && monsFatigue < monsMaxFatigue)
        {
            battleFlow.currentDammage = monsterDamagePower;
            GetComponent<Animator>().SetTrigger("attackTrigger");
            Instantiate(attackParticle, new Vector2(3.02788f, -3.37f), attackParticle.rotation);
            StartCoroutine(returnMon());
            battleFlow.whichTurn = 1;
        }



    }

    IEnumerator returnMon()
    {
        yield return new WaitForSeconds(1.5f);
        Instantiate(damageTextObj, new Vector2(-5.3f, -2.5f), damageTextObj.rotation);
        wiz_control.wizFatigue += battleFlow.currentDammage;
        Debug.Log(wiz_control.wizFatigue);
    }
}

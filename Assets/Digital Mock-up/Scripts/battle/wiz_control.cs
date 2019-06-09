using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class wiz_control : MonoBehaviour {

    public Transform sleepPowderObj;
    public Transform musicNodeObj;
    public Transform blanketObj;
    public Transform warmMilkObj;
    public Transform drainObj;


    public Transform damageTextObj;
    public Transform healTextObj;

    public static int lullabyStock;
    public static int warmMilkStock;
    public static int blanketStock;
    public static int drainStock;
    public static int eternalSleepStock;

    public static float wizFatigue = 0;
    public static float wizMaxFatigue = 100;

    public Text[] numberLabels = new Text[5];
    public Text sleepText;
    public Text enemyImmuneText;
    // Use this for initialization
    void Start () {
        numberLabels[0].text = lullabyStock.ToString();
        numberLabels[1].text = warmMilkStock.ToString();
        numberLabels[2].text = blanketStock.ToString();
        numberLabels[3].text = drainStock.ToString();
        numberLabels[4].text = eternalSleepStock.ToString();
        
    }
	
	// Update is called once per frame
	void Update () {
        
        if (wizFatigue >= wizMaxFatigue)
        {
            wizFatigue = wizMaxFatigue;
            SceneManager.LoadScene("Gameover");
        }
        if (wizFatigue < 0)
        {
            wizFatigue = 0;
        }
        sleepText.text = wizFatigue.ToString();

        // Debug Area
        /*
        if (battleFlow.immuneBlanket)
        {
            Debug.Log("Sprite Work");
        }
        */
    }

    IEnumerator returnWiz()
    {
        yield return new WaitForSeconds(1.5f);
        Instantiate(damageTextObj, new Vector2(3f, -2.1f), damageTextObj.rotation);
        battleFlow.damageDisplay = "y";
        battleFlow.whichTurn = 2;
        battleFlow.noSpamBug = true;
    }

    IEnumerator returnDrain()
    {
        yield return new WaitForSeconds(1.5f);
        Instantiate(damageTextObj, new Vector2(3f, -2.1f), damageTextObj.rotation);
        Instantiate(healTextObj, new Vector2(-4.9f, -2.1f), healTextObj.rotation);
        wizFatigue -= 30;
        battleFlow.damageDisplay = "y";
        battleFlow.whichTurn = 2;
        battleFlow.noSpamBug = true;
    }

    IEnumerator waitForSecond(float secondsWait)
    {
        yield return new WaitForSeconds(secondsWait);
        enemyImmuneText.text = "";
    }


    public void lullaby()
    {
        if (battleFlow.immuneLullaby)
        {
            enemyImmuneText.text = "The monster is immune to this spell, choose a different spell.";
            
            StartCoroutine(waitForSecond(1.5f));
            
        } else
        {
            //enemyImmuneText.text = "";
            if (battleFlow.whichTurn == 1 && lullabyStock > 0 && battleFlow.noSpamBug)
            {
                battleFlow.noSpamBug = false;
                battleFlow.currentDammage = 10f;
                GetComponent<Animator>().SetTrigger("attackTrigger");
                Instantiate(musicNodeObj, new Vector2(-4.4f, -3.2f), musicNodeObj.rotation);
                StartCoroutine(returnWiz());

                // Minus stock
                lullabyStock--;
                numberLabels[0].text = lullabyStock.ToString();
            }
        }
        
    }

    public void warmMilk()
    {
        //enemyImmuneText.text = "";
        if (battleFlow.whichTurn == 1 && warmMilkStock > 0 && battleFlow.noSpamBug)
        {
            battleFlow.noSpamBug = false;
            battleFlow.currentDammage = 50.0f;
            GetComponent<Animator>().SetTrigger("attackTrigger");
            Instantiate(warmMilkObj, new Vector2(-4.4f, -3.2f), warmMilkObj.rotation);
            StartCoroutine(returnWiz());

            // Minus stock
            warmMilkStock--;
            numberLabels[1].text = warmMilkStock.ToString();
        }
    }

    public void blanket()
    {
        if (battleFlow.immuneBlanket)
        {
            enemyImmuneText.text = "The monster is immune to this spell, choose a different spell.";
            StartCoroutine(waitForSecond(1.5f));


        } else
        {
            //enemyImmuneText.text = "";
            if (battleFlow.whichTurn == 1 && blanketStock > 0 && battleFlow.noSpamBug)
            {
                battleFlow.noSpamBug = false;
                battleFlow.currentDammage = 20f;
                GetComponent<Animator>().SetTrigger("attackTrigger");
                Instantiate(blanketObj, new Vector2(-4.4f, -3f), blanketObj.rotation);
                StartCoroutine(returnWiz());

                // Minus stock
                blanketStock--;
                numberLabels[2].text = blanketStock.ToString();
            }
        }
        

    }

    public void drain()
    {
        if (battleFlow.immuneDrain)
        {
            enemyImmuneText.text = "The monster is immune to this spell, choose a different spell.";
            StartCoroutine(waitForSecond(1.5f));

        } else
        {
            //enemyImmuneText.text = "";
            if (battleFlow.whichTurn == 1 && drainStock > 0 && battleFlow.noSpamBug)
            {
                battleFlow.noSpamBug = false;
                battleFlow.currentDammage = 30f;
                GetComponent<Animator>().SetTrigger("attackTrigger");
                Instantiate(drainObj, new Vector2(3.02788f, -3.37f), drainObj.rotation);
                StartCoroutine(returnDrain());

                // Minus stock
                drainStock--;
                numberLabels[3].text = drainStock.ToString();
            }
        }

        
    }

    public void eternalSleep()
    {
        //enemyImmuneText.text = "";
        if (battleFlow.whichTurn == 1 && eternalSleepStock > 0 && battleFlow.noSpamBug)
        {
            battleFlow.noSpamBug = false;
            battleFlow.currentDammage = 999f;
            GetComponent<Animator>().SetTrigger("attackTrigger");
            Instantiate(sleepPowderObj, new Vector2(-4.4f, -3f), sleepPowderObj.rotation);
            StartCoroutine(returnWiz());

            // Minus stock
            eternalSleepStock--;
            numberLabels[4].text = eternalSleepStock.ToString();
        }
    }
    
}

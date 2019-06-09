using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battleFlow : MonoBehaviour {

    public static int whichTurn = 1;
    public static float currentDammage = 0;

    public static string damageDisplay = "n";

    public static bool immuneBlanket = false;
    public static bool immuneDrain = false;
    public static bool immuneLullaby = false;
    public static bool noSpamBug = true;

    // No Blankets
    public Sprite spritemonsterNoBlanket;
    public Sprite spritemonsterNoBlanket2;
    public Sprite spritemonsterNoBlanket3;

    // No Drain
    public Sprite spriteMonsterNoDrain;
    public Sprite spriteMonsterNoDrain2;
    public Sprite spriteMonsterNoDrain3;

    // No Lullaby
    public Sprite spriteMonsterNoLullaby;
    public Sprite spriteMonsterNoLullaby2;
    public Sprite spriteMonsterNoLullaby3;


    // Use this for initialization
    void Start () {
        whichTurn = 1;
        if (mon_control.spritemonster == spritemonsterNoBlanket ||
            mon_control.spritemonster == spritemonsterNoBlanket2 ||
            mon_control.spritemonster == spritemonsterNoBlanket3)
        {
            immuneBlanket = true;
        }

        if (mon_control.spritemonster == spriteMonsterNoDrain ||
            mon_control.spritemonster == spriteMonsterNoDrain2 ||
            mon_control.spritemonster == spriteMonsterNoDrain3)
        {
            immuneDrain = true;
        }

        if (mon_control.spritemonster == spriteMonsterNoLullaby ||
            mon_control.spritemonster == spriteMonsterNoLullaby2 ||
            mon_control.spritemonster == spriteMonsterNoLullaby3)
        {
            immuneLullaby = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

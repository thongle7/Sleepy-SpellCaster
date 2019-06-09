using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarDamage : MonoBehaviour {

    public GameObject wiz;
    private SpriteRenderer wizSprite;
    private Image image;
    private Color curColor;
	// Use this for initialization
	void Start () {
        wizSprite = wiz.GetComponent<SpriteRenderer>();
        image = GetComponent<Image>();
        curColor = image.color;
	}
	
	// Update is called once per frame
	void Update () {
		if(wizSprite.color.Equals(Color.red))
        {
            image.color = Color.red;
        }
        else
        {
            image.color = curColor;
        }
	}
}

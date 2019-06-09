using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour {

    private float fillAmount;

    [SerializeField]
    private float lerpSpeed;

    [SerializeField]
    private Image content;

    [SerializeField]
    private Text valueText;

    //decides max value of the bar
    public float MaxValue { get; set; }

    public float Value
    {
        set
        {
            valueText.text = value.ToString();
            fillAmount = Map(value, 0, MaxValue, 0, 1);
        }
    }

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        HandleBar();
	}

    private void HandleBar()
    {
        //only update bar when the fillAmunt changes
        if (fillAmount != content.fillAmount)
        {
            content.fillAmount = Mathf.Lerp(content.fillAmount, fillAmount, Time.deltaTime * lerpSpeed);
        }
    }

    private float Map(float value, float sleepMin, float sleepMax, float fillMin, float fillMax)
    {
        return (value - sleepMin) * (fillMax - fillMin) / (sleepMax - sleepMin) + fillMin;
    }
}

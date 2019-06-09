using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{	
    
	public float jumpStrength = 10f;

    public float JumpRate = 1f;

    private float nextJump = 0f;

    public GameObject Wind;



    void Update()
    {
        if (GameTime.isPaused) return;
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextJump)
        {
            nextJump = Time.time + JumpRate;

            // Apply an instantaneous upwards force
            Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pz.z = 0;

            Vector3 heading = (transform.position - pz).normalized;
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            GetComponent<Rigidbody2D>().angularVelocity = 0;
            GetComponent<Rigidbody2D>().AddForce(heading * jumpStrength, ForceMode2D.Impulse);


            Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);
            Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);
            
            float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);

            Quaternion windDirection =  Quaternion.Euler(new Vector3(180-angle, 90f, 0));

            Instantiate(Wind, transform.position, windDirection);

        }
    }
	

    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
    
}
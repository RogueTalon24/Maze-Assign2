using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallReset : MonoBehaviour {

    private Vector3 home;
	public int health;
	public Text hText;
	// Use this for initialization
	void Start () {
        home = transform.position;
		health = 10;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < -1f) {
            transform.position = home;
        }

		//if health <= 0 reset
		if(health<0||health == 0)
        {
			transform.position = home;
			health = 10;
			GameObject healthText = GameObject.Find("HealthText");
			hText = healthText.GetComponent<Text>();
			hText.text = health.ToString();
		}
	}
}

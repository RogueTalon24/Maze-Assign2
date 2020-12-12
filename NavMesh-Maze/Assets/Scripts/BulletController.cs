using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletController : MonoBehaviour {
    public float speed = 1f;

    private GameObject player;
    public Text health;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 pos = transform.position;
        Vector3 direction = player.transform.position - transform.position;
        direction.y += 0.5f;
        direction = Vector3.Normalize(direction) * speed / 100f;
        pos = pos + direction;
        transform.position = pos;
	}

    private void OnCollisionEnter(Collision collision)
    {
        player.GetComponent<FallReset>().health -= 1;
        GameObject healthText = GameObject.Find("HealthText");
        health = healthText.GetComponent<Text>();
        health.text = player.GetComponent<FallReset>().health.ToString();
        Destroy(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Made by Jesus Papania

public class PlatformController : MonoBehaviour
{

    public GameObject Player;
    public GameObject Enemies;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Player)
        {
            Player.transform.parent = transform;
            Player.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (other.gameObject == Enemy1)
        {
            Enemy1.transform.parent = transform;
        }
        if (other.gameObject == Enemy2)
        {
            Enemy2.transform.parent = transform;
        }
        if (other.gameObject == Enemy3)
        {
            Enemy3.transform.parent = transform;
        }
        if (other.gameObject == Enemy4)
        {
            Enemy4.transform.parent = transform;
        }
        if (other.gameObject == Enemy5)
        {
            Enemy5.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = null;
            Player.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (other.gameObject == Enemy1)
        {
            Enemy1.transform.parent = Enemies.transform;
        }
        if (other.gameObject == Enemy2)
        {
            Enemy2.transform.parent = Enemies.transform;
        }
        if (other.gameObject == Enemy3)
        {
            Enemy3.transform.parent = Enemies.transform;
        }
        if (other.gameObject == Enemy4)
        {
            Enemy4.transform.parent = Enemies.transform;
        }
        if (other.gameObject == Enemy5)
        {
            Enemy5.transform.parent = Enemies.transform;
        }
    }
}

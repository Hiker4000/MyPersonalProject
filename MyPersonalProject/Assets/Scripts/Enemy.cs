using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody EnamyRb;
    public float speed = 3.0f;
    private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
       EnamyRb = GetComponent<Rigidbody>();
       Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 LookDirection = (Player.transform.position - transform.position).normalized;
        EnamyRb.AddForce(LookDirection * speed);
    }
}

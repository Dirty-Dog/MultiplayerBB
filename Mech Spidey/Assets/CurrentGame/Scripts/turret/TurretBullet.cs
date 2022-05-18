using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBullet : MonoBehaviour
{
    Rigidbody rb;
    int force;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        force = 15;
    }

    // Update is called once per frame
    void Update()
    {
       rb.AddForce(0,0,force,ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        print("bammmmm destroyedd");
        Destroy(gameObject);
    }
}

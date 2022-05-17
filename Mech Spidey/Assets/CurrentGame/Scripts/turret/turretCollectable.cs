using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretCollectable : MonoBehaviour
{
    [SerializeField] private GameObject collectable, turret , particle_system, player;
    [SerializeField] private int timeToDestroyParticle;

    private void Start()
    {
        particle_system.SetActive(false);
        turret.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        turret.SetActive(true);
        player.SetActive(false);
        particle_system.SetActive(true);
        Destroy(particle_system, timeToDestroyParticle);
        Destroy(collectable);
    }

}

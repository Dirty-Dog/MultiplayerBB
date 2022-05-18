using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class turretShoot : MonoBehaviour
{
    [SerializeField] private bool canShoot;
    [SerializeField] private GameObject bullet;
    //[SerializeField] private ParticleSystem particles;
    private AudioSource bullet_sound;
    [SerializeField] private AudioClip bulletaudioClip;
    [SerializeField] private Transform muzzel;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        bullet_sound = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && canShoot)
        {
            canShoot = false;
            //instanciate bullet
            print("bullet bammm");
            anim.SetTrigger("Shot");
            Instantiate(bullet,muzzel);
            //vfx activateq
            print("phushhhhh particles");
            //particles.Play();
            //sound 
            print("peww pewww");
            // adding audiou clip

            // paly audio
            bullet_sound.clip = bulletaudioClip;
            bullet_sound.Play();
            Invoke("canShootTrue", 0.1f);

        }
    }

    // delay function
    void canShootTrue()
    {
            canShoot = true;
    }
    

}

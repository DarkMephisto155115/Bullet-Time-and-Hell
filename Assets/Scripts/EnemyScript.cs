using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[SelectionBase]
public class EnemyScript : MonoBehaviour
{
    Animator anim;
    public bool dead;
    public Transform weaponHolder;
    public NavMeshAgent enemy;
    public Transform player;
    AudioSource m_dead_sfx;
    KillCounter killCounterScript;

    void Start()
    {
        m_dead_sfx = GetComponent<AudioSource>();
        killCounterScript = GameObject.Find("KCO").GetComponent<KillCounter>();
        anim = GetComponent<Animator>();
        StartCoroutine(RandomAnimation());

        if (weaponHolder.GetComponentInChildren<WeaponScript>() != null)
            weaponHolder.GetComponentInChildren<WeaponScript>().active = false;

    }

    void Update()
    {
        if (!dead)
        {
            transform.LookAt(new Vector3(Camera.main.transform.position.x, 0, Camera.main.transform.position.z));
            Move();
        }
            


    }

    public void Move()
    {
        if (anim.enabled == false)
        {
            enemy.SetDestination(player.position);
        }
        
    }

    public void Ragdoll()
    {
        anim.enabled = false;
        BodyPartScript[] parts = GetComponentsInChildren<BodyPartScript>();
        foreach (BodyPartScript bp in parts)
        {
            bp.rb.isKinematic = false;
            bp.rb.interpolation = RigidbodyInterpolation.Interpolate;
        }
        dead = true;
        if (dead)
        {
            m_dead_sfx.Play();
        }
        

        if (weaponHolder.GetComponentInChildren<WeaponScript>() != null)
        {
            WeaponScript w = weaponHolder.GetComponentInChildren<WeaponScript>();
            if (w.bulletAmount > 0)
            {
                w.Release();
                killCounterScript.addKill();
            }
        }
    }

    public void Shoot()
    {
        if (dead)
            return;

        if (weaponHolder.GetComponentInChildren<WeaponScript>() != null)
            weaponHolder.GetComponentInChildren<WeaponScript>().Shoot(GetComponentInChildren<ParticleSystem>().transform.position, transform.rotation, true);
    }

    IEnumerator RandomAnimation()
    {
        anim.enabled = false;
        yield return new WaitForSecondsRealtime(Random.Range(.1f, .5f));
        anim.enabled = true;

    }
}

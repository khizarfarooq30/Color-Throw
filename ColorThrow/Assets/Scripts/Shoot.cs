using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectile;
    public Transform shotPoint;

    Animator anim;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Dancing", true);
        }
    }

    public void ShootProjectile()
    {
        Instantiate(projectile, shotPoint.transform.position, shotPoint.transform.rotation);
        
        anim.SetBool("Dancing", false);
    }
}

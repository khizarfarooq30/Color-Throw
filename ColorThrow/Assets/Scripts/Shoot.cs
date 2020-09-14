using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject projectile;
    public Transform shotPoint;

    Animator anim;

    bool isPressed;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
        isPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isPressed)
        {
            anim.SetBool("Dancing", true);
            isPressed = true;
        }
    }

    public void ShootProjectile()
    {
        Instantiate(projectile, shotPoint.transform.position, shotPoint.transform.rotation);
        isPressed = false;
        anim.SetBool("Dancing", false);
    }
}

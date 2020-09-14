using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RotateControl : MonoBehaviour
{
    public float speed = 60f;
    bool isPressed = false;

    // Update is called once per frame
    void Update()
    {

     
       if (Input.GetKeyDown(KeyCode.D) && !isPressed)
        {
            isPressed = true;
            StartCoroutine(Rotate(90));
        }

        
        if (Input.GetKeyDown(KeyCode.A) && !isPressed)
        {
            isPressed = true;
            StartCoroutine(Rotate(-90));
        }
/*
        if(Input.GetKeyDown(KeyCode.Space) && !isPressed){
            isPressed = true;
            anim.SetTrigger("ThrowColor");
            StartCoroutine(ShootProjectile());
        }*/ 
    }

    IEnumerator Rotate(float rotationAmount) {
        Quaternion finalRotation = Quaternion.Euler(0, rotationAmount, 0) * this.transform.rotation;

        while (this.transform.rotation != finalRotation)
        {
            this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, finalRotation, Time.deltaTime * speed);
            yield return 0;
        }

        isPressed = false;
    }



   

}

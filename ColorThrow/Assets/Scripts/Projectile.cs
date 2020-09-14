using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{   
    public float speed = 30f;
    Renderer rn;

    private void Start() {
        Invoke("DestroyProjectile", 0.7f);
        rn = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
       
    }

    void DestroyProjectile(){

        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Blue" && gameObject.tag == "BlueBullet") {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (other.tag == "Red" && gameObject.tag == "RedBullet")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (other.tag == "Green" && gameObject.tag == "GreenBullet")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    
        Destroy(gameObject);
    }

    public void BlueSelected() {
        this.gameObject.tag = "BlueBullet";
        this.gameObject.GetComponent<Renderer>().sharedMaterial.color = Color.blue;

    }
    
    public void RedSelected()
    {
        this.gameObject.tag = "RedBullet";
        this.gameObject.GetComponent<Renderer>().sharedMaterial.color = Color.red;  
    }

    public void GreenSelected()
    {
        this.gameObject.tag = "GreenBullet";
        this.gameObject.GetComponent<Renderer>().sharedMaterial.color = Color.green;
    }
}

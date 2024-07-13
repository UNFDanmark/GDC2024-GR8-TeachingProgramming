using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float coolDownTimeNormal = 0.3f;
    public float coolDownTimeRapid = 0.12f;
    private float leftOverCooldown = 0;
    private bool rapidFire = false;
    public float bulletSpeed = 1;
    void Start()
    {
        
    }

    void Update()
    {
        leftOverCooldown -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.F))
        {
            rapidFire = !rapidFire;
        }

        if (rapidFire)
        {
            if (Input.GetKey(KeyCode.Space) && leftOverCooldown <= 0)
            {
                leftOverCooldown = coolDownTimeRapid;
                GameObject bulletClone = Instantiate(bulletPrefab,transform.position, Quaternion.identity);
                Vector3 bulletDirection = transform.forward * 1000 * bulletSpeed;
                Rigidbody bulletRB = bulletClone.GetComponent<Rigidbody>();
                bulletRB.AddForce(bulletDirection);
                GameObject.Destroy(bulletClone, 1.5f);
                
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space) && leftOverCooldown <= 0)
            {
                leftOverCooldown = coolDownTimeNormal;
                GameObject bulletClone = Instantiate(bulletPrefab,transform.position, Quaternion.identity);
                Vector3 bulletDirection = transform.forward * 1000 * bulletSpeed;
                Rigidbody bulletRB = bulletClone.GetComponent<Rigidbody>();
                bulletRB.AddForce(bulletDirection);
                GameObject.Destroy(bulletClone, 1.5f);
            }
        }
    }
}

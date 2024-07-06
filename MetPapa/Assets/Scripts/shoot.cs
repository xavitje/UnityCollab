using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform bulletspawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;
    public float tijd = 2f;
    public GameObject bullet;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            main();
                  
        }
       
    }

    public void main()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletspawnPoint.position, bulletspawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletspawnPoint.forward * bulletSpeed;
        Destroy(bullet, tijd);
        return;
    }
    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHeatScript : MonoBehaviour {

    public int weaponHeat;
    int weaponHeatCount = 1;
    public GameObject bullet;
    public int poolCount = 1;
 
    List<GameObject> bullets;

    // Use this for initialization
    void Start () {
        StartCoroutine (WeaponOverHeating());
        bullets = new List<GameObject>();
        /* for (int i = 0; i < poolCount; i++)
         {
             GameObject obj = (GameObject)Instantiate(bullet);
             obj.SetActive(false);
             bullets.Add(obj);
         }*/
        print("weapon 1");
	}

    void Fire()
    {
        for (int i = 0; i < bullets.Count; i++)
        {
            if (!bullets[i].activeInHierarchy)
            {
                bullets[i].transform.position = transform.position;
                bullets[i].transform.rotation = transform.rotation;
                bullets[i].SetActive(true);
                break;
            }
        }
    }

    IEnumerator WeaponOverHeating()
    {
        while ( weaponHeatCount < weaponHeat)
        {
            
            print(weaponHeatCount );
            FireWeapon();
            
        }

      /*  if (weaponHeatCount < weaponHeat && weaponHeatCount > 0)
        {
            weaponHeatCount -= Time.deltaTime;
            print(weaponHeatCount);

        }*/

        //issue is that the if statement runs once then will run the rest putting in an infinite loop. 
        yield return new WaitForSeconds(5);
        weaponHeatCount++;
        StartCoroutine(WeaponCoolDown());
        Fire();
     }

    void FireWeapon() {
        
        print("weapon is firing");
    }

    IEnumerator WeaponCoolDown()
    {
        
        while (true)
        {

            while (weaponHeatCount >= weaponHeat)
            {
                weaponHeatCount--;
                print("weapon cooling");
            }
            yield return new WaitForSeconds(5);
        }
    }
}

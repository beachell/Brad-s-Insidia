using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldWeaponHeatScript : MonoBehaviour {


    public float weaponHeat = 10;
    public  float weaponHeatCount = 1;
    public float neededCount = 9;


    // Use this for initialization
    void Start()
    {
       // neededCount = weaponHeat - 1;
        StartCoroutine(WeaponOverHeating());
        StartCoroutine(WeaponCooling());
        print("weapon 2");
    }

    IEnumerator WeaponOverHeating()
    {
        if (weaponHeatCount > neededCount)
        {


            while (weaponHeatCount <= weaponHeat)
            {
                print(weaponHeatCount + "heat");
                weaponHeatCount++;
                FireWeapon();
                neededCount++;
                yield return new WaitForSeconds(1);
            }
        }
        /*  if (weaponHeatCount < weaponHeat && weaponHeatCount > 0)
          {
              weaponHeatCount -= Time.deltaTime;
              print(weaponHeatCount);

          }*/

        //issue is that the if statement runs once then will run the rest putting in an infinite loop. 

        //weaponHeatCount = 1;
        // print("count reset");
        yield return new WaitForSeconds(10);
    }


    IEnumerator WeaponCooling()
    {
        while (true)
        {


            while (weaponHeatCount >= weaponHeat)
            {

                print(weaponHeatCount + "cooling");
                weaponHeatCount--;
                neededCount--;
                yield return new WaitForSeconds(2f);
                //StopCoroutine(WeaponOverHeating());
            }
        }
    }


    void FireWeapon()
    {
        print("weapon is firing");
    }
}

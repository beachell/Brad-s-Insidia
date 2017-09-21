using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public float speed = 2;
    Vector3 tempMove;

	// Use this for initialization
	void Start () {

       // StartCoroutine(BulletTravel());
    }

    /* private IEnumerator BulletTravel()
     {
         if (1<2)
         {
             transform.Translate(speed * Time.deltaTime, 0, 0);
             yield return new WaitForSeconds(0.2f);
             print("I ran");
         }
     }
     */
    
}

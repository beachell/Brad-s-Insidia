using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurretAI : MonoBehaviour {

    // public Transform Target;
    //  GameObject NewTarget;
    Coroutine LookingTarget;

   
    //when a player enters into this area it will start the targetingSystem coroutine to look at the target.
    public void OnTriggerEnter (Collider Target) {
        LookingTarget = StartCoroutine(TargetingSystem(Target));
        print("intruder detected");
        
        //get the object that entered the area to target it. 
	}

    //this will target what ever is in the trap area and look at it. When the player leaves it will stop looking and shooting
    IEnumerator TargetingSystem(Collider newTarget) {
        while (true)
        {
            
           // print("I should be looking at the target");
            this.transform.LookAt(newTarget.transform);
            yield return new  WaitForSeconds(0.01f);
            //enter the calling for the shooting here

        }
       
       
    }
    public void OnTriggerExit(Collider Target)
    {
        StopCoroutine(LookingTarget);
    }
}


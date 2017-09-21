using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWeaponScript : MonoBehaviour {


    public int heatMax = 10;
    public int heatStart = 0;
    public bool overHeated = false;



    public void GotClicked()
    {
        //this will be replaced by being called from the character controller script later
        if (!overHeated)
        {
            StartCoroutine(OverHeating());

        }


    }
    //this will check the heat and if not overheated it will increase the heat
    private IEnumerator OverHeating()
    {

        if (overHeated == false)
        {
            // print("coroutine running");
            HeatCheck();
            print(heatStart);
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(OverHeating());
        }
        else
        {

            StartCoroutine(CoolDown());




        }


    }
    //this will decrease the heat if it is overheated
    IEnumerator CoolDown()
    {
        if (heatStart > 0)
        {

            overHeated = true; heatStart--;
            print(heatStart + "cooldown count");
            yield return new WaitForSeconds(1);
            StartCoroutine(OverHeating());

        }
        else overHeated = false;
    }


    //this increases the heat when it is called by the newheatcode coroutine. 
    //When it is overheated it changes the bool to true.
    public void HeatCheck()
    {
        // print("heatcheck was called");
        if (heatStart < heatMax)
        {
            //insert shooting ref or script here.
            heatStart++;
        }
        else
        {
            overHeated = true;
        }

    }


}


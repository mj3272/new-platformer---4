using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    
    public Image fillBar;
    public float health;


    public void LoseHealth(int value){

        if(health<=0){

            return;
        }

        //reduce the health
        health -= value;
        //refresh the bar
        fillBar.fillAmount = health/100;
        //check if health is 0 or less -> dead
        if(health<=0){

            FindObjectOfType<PlayerMovement>().Die();
            //Debug.Log("you died");
            

        }


    }

    private void Update(){


/*
        if(Input.GetKeyDown(KeyCode.Return)){

            LoseHealth(25);
        }
*/
    }


}

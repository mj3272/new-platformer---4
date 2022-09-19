using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    
    public Image fillBar;
    public float health;

    [SerializeField] private AudioSource hurtSound;
    [SerializeField] private AudioSource deathSound;

    public void LoseHealth(int value){

        if(health<=0){

            return;
        }

        //reduce the health
        health -= value;
        //refresh the bar
        fillBar.fillAmount = health/100;

        hurtSound.Play();
        //check if health is 0 or less -> dead
        if(health<=0){

            deathSound.Play();
            Invoke("ZeroHealth", 1.2f);
            

        }


    }

    private void ZeroHealth(){
        
        FindObjectOfType<PlayerMovement>().Die();
        //Debug.Log("you died");

    }


}

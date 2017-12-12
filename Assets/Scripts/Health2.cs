using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Health2 : MonoBehaviour {
    //health variables
    public float health;
    public float currentHealth=0f;
    public float DmgAmount;

    //txt variables
    public Text dead;

    //sound for damage
    public AudioClip dmg;
    public AudioClip death;

    //indicator/image for when damage is taken
    public float flashSpeed = 5f;
    public Color flashColor = new Color(1f, 0f, 0f, 0.1f);
    public Image dmgImage;

    //HealthBar
    public Slider HealthBar;

    // Use this for initialization
    void Start () { 
        currentHealth = health;

        //assign value of health to slider
        HealthBar.value = CalculateHealth();
    }
	
	// Update is called once per frame
	void Update () {

    }

    private void FixedUpdate()
    {
        if (currentHealth == 0)
        {
            SceneManager.LoadScene("SurvivalDeath");
            Debug.Log("Dead");
            
        }
    }

    /*private void MakeDead()
    {
        
        //SceneManager.LoadScene("StartMenu");
        Debug.Log("Dead");
    }
    */
    float CalculateHealth()
    {
        return currentHealth / health;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("asteroid"))
        {
            other.gameObject.SetActive(false);
            if (currentHealth <= health)
            {
                currentHealth -= DmgAmount;
                HealthBar.value = CalculateHealth();
            }
        }
    }
    
}

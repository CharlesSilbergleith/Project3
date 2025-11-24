using JetBrains.Annotations;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;
   
    public float healthPercent;

   
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      healthPercent = currentHealth / maxHealth;
     
    }

    //take damage function
    public virtual void TakeDamage(float damage)
    {
        currentHealth -= damage;


       
        
        if (!IsAlive())
        {
            currentHealth = 0;
            Die();
        }
    }
    public virtual void TakeDamage() {
        currentHealth -= 5;




        if (!IsAlive())
        {
            currentHealth = 0;
            Die();
        }
    }






    //heal
    public void Heal(float amount) {
        currentHealth += amount;
        if (currentHealth > maxHealth) {
            currentHealth = maxHealth;
        }
    
    }
    public void Die() { 
        //get death
        Death death = GetComponent<Death>();
        //check death
        if (death != null) { 
            //die
            death.Die();
            
            Heal(maxHealth);
        }
    }

    //check if alive
    public bool IsAlive()
    {
        if (currentHealth > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


   }

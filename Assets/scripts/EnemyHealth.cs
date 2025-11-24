using UnityEngine;
using UnityEngine.UI;


public class EnemyHealth : Health
{
    
    [SerializeField] private Image healthBar;
    void Start()
    {
        healthBar.fillAmount = 1;
    }

    public void updateHealthBar() {
        healthBar.fillAmount = healthPercent;
    }
    public override void TakeDamage(float damage)
    {
        currentHealth -= damage;
        updateHealthBar();



        if (!IsAlive())
        {
            currentHealth = 0;
            Die();
        }
    }
    public override void TakeDamage()
    {
        currentHealth -= 5;
        updateHealthBar();



        if (!IsAlive())
        {
            currentHealth = 0;
            Die();
        }
    }

}

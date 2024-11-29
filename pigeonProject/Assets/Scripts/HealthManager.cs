using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    [SerializeField] private AudioClip clip;
    [SerializeField] private AudioClip damageClip;
    public float healthAmount = 100f;
    public Image healthBar;

    void Update()
    {
        if (healthAmount <= 0) 
        {
            Debug.Log("Health depleted. Reloading level...");
            //Debug.Log(clip);
            //if (clip != null)
            //{
                SoundFXManager.instance.PlaySoundFXClip(clip);
            //}
            ReloadLevel();
        }

        if (Input.GetKeyDown(KeyCode.Return)) 
        {
            TakeDamage(20);
        }
    }

    public void TakeDamage(float damage)
    {
        SoundFXManager.instance.PlaySoundFXClip(damageClip);
        healthAmount -= 30;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100); 
        UpdateHealthBar();
    }

    public void Heal(float healingAmount)
    {
        healthAmount += healingAmount;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100); 
        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        if (healthBar != null)
        {
            healthBar.fillAmount = healthAmount / 100f; 
        }
    }

    private void ReloadLevel()
    {
        healthAmount = 100f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
}

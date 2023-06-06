using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
   private PlayerHealth playerHealthScript;
    public Image fillImage;
    private  Slider slider;
    public int currentHealth;
    public int maxHealth;

    // Start is called before the first frame update
    void Awake()
    {
      currentHealth = GetComponent<PlayerHealth>().currentHealth;
      maxHealth = GetComponent<PlayerHealth>().maxHealth;
      slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
       float fillValue = currentHealth / maxHealth;
       slider.value = fillValue;
    }
}

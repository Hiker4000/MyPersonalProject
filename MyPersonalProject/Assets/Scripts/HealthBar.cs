using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public PlayerHealth playerHealthScript;
    public Image fillImage;
    private  Slider slider;

    // Start is called before the first frame update
    void Awake()
    {
       slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
       float fillValue = PlayerHealth.CurrentHealth / PlayerHealth.MaxHealth;
       slider.value = fillValue;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth = 1;
    // Start is called before the first frame update
    void Start()
    {
       currentHealth = maxHealth; 
    }

   
}

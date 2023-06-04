using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int MaxHealth = 10;
    public int CurrentHealth = 1;
    // Start is called before the first frame update
    void Start()
    {
       CurrentHealth = MaxHealth; 
    }

   
}

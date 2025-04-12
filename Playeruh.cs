using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playeruh : MonoBehaviour
{
    private int health = 100;
    // Start is called before the first frame update
    public void TakeDamage(int damage)
    {
        health-=damage;
        print("ОЗ: " + health);
    }
}

//паригадам дам дам дамдам дам дам дам дам дам 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 5;
    public int level = 1;
    public float speed = 9f;

    Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {
        health += level;
    }

    // Update is called once per frame
    void Update()
    {
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
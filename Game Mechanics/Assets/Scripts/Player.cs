using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health = 100;
    public Vector3 direction = Vector3.left;
    public float velocity = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void IncreaseHealth(float amount)
    {
        this.health += Math.Abs(amount);
        Debug.Assert(this.health > 0);
    }

    public void DecreaseHealth(float damage)
    {
        this.health -= Math.Abs(damage);
        Debug.Assert(this.health > 0);
    }

    public void Movement()
    {
        Vector3 direction = this.direction.normalized;
        this.transform.position += direction * (velocity * Time.deltaTime);
    }
}

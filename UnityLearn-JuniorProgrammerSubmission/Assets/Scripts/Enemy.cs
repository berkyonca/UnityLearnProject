using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : HumanBehaviour
{

    private int _health = 40;
    public int EnemyHealth => _health;



    private void Start()
    {
        Health(_health);
    }






}

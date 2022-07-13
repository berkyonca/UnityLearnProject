using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : HumanBehaviour
{
    [SerializeField] Player _player;
    [SerializeField] EnemyScriptableObject _enemyScriptable;
    public int EnemyHealth
    {
        get { return _enemyScriptable.EnemyHealth; }
        set { _enemyScriptable.EnemyHealth = value; }
    }
    public int EnemyDamage => _enemyScriptable.EnemyDamage;
    float zaman;

    private void Start()
    {
        Health(EnemyHealth);
        
    }

    private void Update()
    {
        TimeAlgorithm();
    }



    private void TimeAlgorithm()
    {
        zaman += Time.deltaTime;
        if (zaman >= 5)
        {
            zaman -= 5;
            DealDamage(EnemyDamage);
        }
    }

    protected override void DealDamage(int damage)
    {
        _player.MyHealth -= damage;
        Health(EnemyHealth);
    }

}

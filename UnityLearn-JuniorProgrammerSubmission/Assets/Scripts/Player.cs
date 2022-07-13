using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : HumanBehaviour
{
    [SerializeField] List<Enemy> Enemys;
    private int _health = 100;
    private int _damage = 7;
    public int MyHealth
    {
        get { return _health; }
        set { _health = value; }
    }


    private void Start() => Health(MyHealth);

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DealDamage(_damage);
        }
    }
    protected override void DealDamage(int damage)
    {
        foreach (Enemy item in Enemys)
        {
            item.EnemyHealth -= damage;
        }
        Health(MyHealth);
    }


}

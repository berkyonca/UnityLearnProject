using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : HumanBehaviour
{
    private int _health = 100;
    public int MyHealth => _health;



    private void Start() => Health(MyHealth);




}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HumanBehaviour : MonoBehaviour
{
    

    protected virtual void Health(int health)
    {
        Debug.Log("I am " + this + "and my health is "+ health );
    }

    protected abstract void DealDamage(int damage);





}

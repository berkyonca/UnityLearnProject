using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HumanBehaviour : MonoBehaviour
{
    

    public virtual void Health(int health)
    {
        Debug.Log("I am " + this + "and my health is "+ health );
    }







}

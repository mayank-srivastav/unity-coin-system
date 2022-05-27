using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinchecker : MonoBehaviour
{
    public Coindisplay pop;

    void OnTriggerEnter(Collider cl)
    {
        pop.addcoin();
        Destroy(gameObject);
    }
    
}
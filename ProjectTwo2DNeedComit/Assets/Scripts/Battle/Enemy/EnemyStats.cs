using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int hp;

    void Start()
    {
        
    }

    void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}

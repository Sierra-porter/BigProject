using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellsStats : CharacterStats
{
     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<CharacterStats>().HpCur -= this.Attack;
        }
        Destroy(gameObject);

    }
}

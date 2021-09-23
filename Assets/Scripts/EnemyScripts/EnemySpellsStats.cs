using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpellsStats : CharacterStats
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<CharacterStats>().HpCur -= this.Attack;
        }
        Destroy(gameObject);

    }
}

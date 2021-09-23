using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loadmylvl : MonoBehaviour
{
    public SaveStats sv;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            sv.SaveStatsChar();
            Application.LoadLevel("AfanasyevDungeonWithBos");
        }

    }
}

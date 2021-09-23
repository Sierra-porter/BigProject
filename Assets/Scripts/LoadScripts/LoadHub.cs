using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadHub : MonoBehaviour
{
    public SaveStats sv;
    public CharacterStats st;
    public endingtest et;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            st.Score += et.Curentscore;
            st.lvl += 1;
            sv.SaveStatsChar();
            Application.LoadLevel("CharacterHub");
        }

    }
}

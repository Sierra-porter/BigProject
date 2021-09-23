using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieHero : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterStats st;
    void Start()
    {

    }

    // Update is called once per frame

    // Update is called once per frame
    void FixedUpdate()
    {
        if (st.HpCur < 0)
        {
            Application.LoadLevel("CharacterHub");

        }
    }
}

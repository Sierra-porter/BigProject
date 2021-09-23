using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class regenerationMana : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterStats st;
    void Start()
    {
        st = gameObject.GetComponent<CharacterStats>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        st.ManaCur += st.ManaRegen;
        if (st.ManaCur > st.ManaMax) st.ManaCur = st.ManaMax;
    }
}

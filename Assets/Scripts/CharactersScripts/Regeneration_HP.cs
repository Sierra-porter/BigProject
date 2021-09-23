using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regeneration_HP : MonoBehaviour
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
        st.HpCur += st.HpRegen;
        if (st.HpCur > st.HpMax) st.HpCur = st.HpMax;
    }
}

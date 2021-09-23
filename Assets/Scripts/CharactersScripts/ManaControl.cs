using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaControl : MonoBehaviour
{
    public CharacterStats st;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (st.ManaMax == 0) return;
        gameObject.GetComponent<Image>().fillAmount = st.ManaCur / st.ManaMax;
    }
}

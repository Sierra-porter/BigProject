using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class K_S_Script : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Score;
    public Text Kills;
    public CharacterStats st;
    void Start()
    {
        Score.text = "Score " + st.Score + "";
       
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Score.text = "Score: " + st.Score + "";

    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endingtest : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Teleport;
    public CharacterStats st;
    public float Curentscore;
    public Text Score;
    public Text Info;



    void Start()
    {
        st.ScoreAward = 0;
        Teleport.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Curent Score: " + " " + st.ScoreAward+"/"+Curentscore;
        if (st.ScoreAward >= Curentscore)
        {
            Info.text = "Go To Teleport!!";
            Teleport.SetActive(true);
        }
    }
}

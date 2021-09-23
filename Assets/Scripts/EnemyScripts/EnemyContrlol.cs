using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContrlol : MonoBehaviour
{
    // Start is called before the first frame update
    private AnimationControl C;
    private Rigidbody2D rb;
    private CharacterStats st;
    D[] Met = new D[5];
    void Start()
    {
        C = gameObject.GetComponent<AnimationControl>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        st = gameObject.GetComponent<CharacterStats>();

        Met[0] = Stand;
        Met[1] = Right;
        Met[2] = Left;
        Met[3] = Down;
        Met[4] = Up;

    }
    bool flag = true;
    private float SpeedX = 0, SpeedY = 0;
    // Update is called once per frame
    public void Stand()
    {
        C.StartAnimationStand();
        SpeedX = 0;
        SpeedY = 0;
    }
    public void Up()
    {
        C.StartAnimationUp();
        SpeedX = 0;
        SpeedY = st.Speed;
    }
    public void Down()
    {
        C.StartAnimationDawn();
        SpeedX = 0;
        SpeedY = -st.Speed;
    }
    public void Left()
    {
        C.StartAnimationLeftRight();
        SpeedX = -st.Speed;
        SpeedY = 0;
        Vector3 V = gameObject.transform.localScale;
        V.x = Mathf.Abs(V.x);
        gameObject.transform.localScale = V;
    }
    public void Right()
    {
        C.StartAnimationLeftRight();
        SpeedX = st.Speed;
        SpeedY = 0;
        Vector3 V = gameObject.transform.localScale;
        V.x = Mathf.Abs(V.x) * (-1);
        gameObject.transform.localScale = V;

    }
    private int I = 0;
    private int Hz = 100;
    delegate void D();
    void FixedUpdate()
    {
        I++;
        if (I > Hz)
        {
            I = 0;
            Met[Random.Range(0, Met.Length)]();
        }
        rb.velocity = new Vector2(SpeedX, SpeedY);

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    // Start is called before the first frame update
    private AnimationControl C;
    private Rigidbody2D rb;
    private CharacterStats st;
    void Start()
    {
        C = gameObject.GetComponent<AnimationControl>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        st = gameObject.GetComponent<CharacterStats>(); 
    }
    private float SpeedX = 0, SpeedY = 0;
    // Update is called once per frame
    public void Stand()
    {
        C.StartAnimationStand();
        SpeedX = 0;
        SpeedY =0;
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
        V.x = Mathf.Abs(V.x)*(-1);
        gameObject.transform.localScale = V;

    }
    public void Ult()
    {
        C.StartAnimationUlt();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Up();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
           Down();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Left();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Right();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<SpellsControl>().FAtack();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.GetComponent<ShieldControl>().ShieldCoolDown();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            gameObject.GetComponent<UltimateSpell>().UltimateCoolDown();
        }

        rb.velocity = new Vector2(SpeedX, SpeedY);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] Stand;
    public Sprite[] Up;
    public Sprite[] Down;
    public Sprite[] LeftRight;
    public SpriteRenderer rd;
    private Sprite[] Control;
    public SpriteRenderer rander;
    public Sprite[] UltimateSprites;
    void Start()
    {
        Control = Stand;
    }
    private int I = 0;
    public int Speed = 60;

    // Update is called once per frame
    void Update()
    {
        AnimationHelp();
    }
    public void StartAnimationStand()
    {
        Control = Stand;
        I = 0;
        ISpeedl = 0;
    }
    public void StartAnimationUlt()
    {
        Control = UltimateSprites;
        I = 0;
        ISpeedl = 0;
    }
    public void StartAnimationUp()
    {
        Control = Up;
        I = 0;
        ISpeedl = 0;
    }
    public void StartAnimationLeftRight()
    {
        Control = LeftRight;
        I = 0;
        ISpeedl = 0;
    }
    public void StartAnimationDawn()
    {
        Control = Down;
        I = 0;
        ISpeedl = 0;
    }
    private int ISpeedl = 0;
    private void AnimationHelp()
    {
        if (I >= Control.Length) I = 0;
        rd.sprite = Control[I];
        if (ISpeedl > Speed)
        {
            ISpeedl = 0;
            I++;
        }
        ISpeedl++;
    }
}

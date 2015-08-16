//----------------------------------------- 
//   Jason Walters 
//   http://glitchbeam.com 
//   @jasonrwalters 
// 
//   last edit on 8/16/2015 
//----------------------------------------- 

using UnityEngine;
using System.Collections;

public class CustomInspector : MonoBehaviour
{
    [Header("Variables")]
    public string string1 = "This is a string";
    public float float1 = 100.0f;
    public int int1 = 10;

    [Header("Sliders")]
    [Range(1f, 10f)]
    public float slider1;
    [Range(1f, 100f)]
    public float slider2;
    [Range(1f, 1000f)]
    public float slider3;

    public enum Selector
    {
        One = 0,
        Two = 1,
        Three = 2,
        Four = 3
    }
    [Header("Drop Down")]
    public Selector select = Selector.One;

    [Header("Need a spaces between variables?")]
    public float var1;
    [Space(5f)]
    public float var2;
    [Space(5f)]
    public float var3;

    [Header("Colors")]
    public Color rgba;
    public Gradient gradient;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
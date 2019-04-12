using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : PropertyAttribute
{

    public readonly string[] Testing;

    public ArrayTest(string[] names)
    {
        this.Testing = names;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

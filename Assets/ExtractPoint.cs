using UnityEngine;
using System.Collections;
using Leap;
using System;

public class ExtractPoint : MonoBehaviour {
    private static int i = 0;
    static int maximum_point_count = 5000;
    public static Vector3[] point_array = new Vector3[maximum_point_count];

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    internal static void LogPoint(Vector3 vector3)
    {
        point_array[i] = vector3;
        i++;
        Debug.Log(i + " Touched Point: " + vector3);
        if(i>999)
        {
            i = 0;
        }
    }
}

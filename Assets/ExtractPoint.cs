using UnityEngine;
using System.Collections;
using Leap;
using System;

public class ExtractPoint : MonoBehaviour {
    private static int i = 0;
    private static Vector3 scaled_position;
    public static GameObject femur_model;
    static int maximum_point_count = 5000;
    public static Vector3[] point_array = new Vector3[maximum_point_count];

    // Use this for initialization
    void Start () {
        //other.DoSomething();
        femur_model = GameObject.Find("Femur CT Scan");
    }
	
	// Update is called once per frame
	void Update () {
        // Here we will move the bone based on finger tip positions

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

    // This function will finally be replaced by the ICP method of comparing point clouds.
    // For now it only tracks the bone obj model along with the finger movements
    internal static void TrackBoneFinger(Vector3 vector3)
    {
        // Default rotation(to align the bone) = 90 degrees
        // Default translation = (-0.065, 0, 0.5)
        //Vector3 bias = new Vector3(-0.5, 0, 1);
        // Scale is (0.001, 0.001, 0.001)
        Vector3 default_translation = new Vector3(65, -80, 50);
        //femur_model.transform.position = (1000*vector3+default_translation)/1000;
        femur_model.transform.position = vector3 + default_translation/2000;
        //femur_model = FindObjectOfType<GameObject>.
    }
}
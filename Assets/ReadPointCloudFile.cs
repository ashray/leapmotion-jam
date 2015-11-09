using UnityEngine;
using System;
using System.Collections;
using System.IO;

public class ReadPointCloudFile : MonoBehaviour {
    public static float[,] stored_point_cloud;
    public test_different_file_read other;
    // Use this for initialization
    void Start () {
        string line;

        // Read the file and display it line by line.
        long size = (new System.IO.FileInfo(@"C:\Users\admin\Desktop\R2_Femur_point_cloud2.txt")).Length;
        System.IO.StreamReader file =
            new System.IO.StreamReader(@"C:\Users\admin\Desktop\R2_Femur_point_cloud2.txt");
        int j = 0;
        int lineCount = File.ReadAllLines(@"C:\Users\admin\Desktop\R2_Femur_point_cloud2.txt").Length;
        stored_point_cloud = new float[lineCount, 3];    // 35 because of the file format.
        while (j < 100 && (line = file.ReadLine()) != null)
        {
            string[] vars = line.Split('\t');
            stored_point_cloud[j, 0] = float.Parse(vars[0]);
            stored_point_cloud[j, 1] = float.Parse(vars[1]);
            stored_point_cloud[j, 2] = float.Parse(vars[2]);
            //Debug.Log(stored_point_cloud[j, 2]);

            j++;
        }
        Debug.Log(stored_point_cloud[1, 0]);
        file.Close();

        other.DoSomething();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class test_different_file_read : MonoBehaviour {
    float[,] imported_model;
    // Use this for initialization
    void Start () {
        
	}
	
    public void DoSomething()
    {
        imported_model = ReadPointCloudFile.stored_point_cloud;

        for (int i = 0; i < 100; i++)
        {
            Debug.Log(imported_model[i, 2]);
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}

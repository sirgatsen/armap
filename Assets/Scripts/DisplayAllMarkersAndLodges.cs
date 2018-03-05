using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayAllMarkersAndLodges : MonoBehaviour {
    public GameObject markers;
    public GameObject lodges;
    // Use this for initialization
    void Start () {
        lodges.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {



        if (!lodges.activeInHierarchy)
        {
            lodges.SetActive(true);
            Debug.Log("Displaying now");
        }
        else
        {
            Debug.Log("Already displayed");
            return;
        }

    }
}
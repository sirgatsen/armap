using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MarkerBehaviour : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject btn;
    // Use this for initialization
    void Start () {

        btn = GameObject.Find("kasane");
        btn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        Application.OpenURL("http://maps.google.com/maps?q=kasane");
        Debug.Log(vb.VirtualButtonName + " button pressed!");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log(vb.VirtualButtonName + " button released!");
    }
}

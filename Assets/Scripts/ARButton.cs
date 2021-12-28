using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARButton : MonoBehaviour,IVirtualButtonEventHandler
{
    public GameObject cubego, spherego;
    VirtualButtonBehaviour vrb;
    // Start is called before the first frame update
    void Start()
    {
        vrb = GetComponentInChildren<VirtualButtonBehaviour> ();
        vrb.RegisterEventHandler(this);
        cubego.SetActive(true);
        spherego.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cubego.SetActive(false);
        spherego.SetActive(true);
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubego.SetActive(true);
        spherego.SetActive(false);
    }
}

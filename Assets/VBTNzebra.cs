using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTNzebra : MonoBehaviour
{
    public VirtualButtonBehaviour Vb;
    public Animation Zebra;

    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);
    }

    // Update is called once per frame
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("button down!!!!");
        Zebra.GetComponent<Animation>().Play();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Zebra.GetComponent<Animation>().Stop();
    }

}

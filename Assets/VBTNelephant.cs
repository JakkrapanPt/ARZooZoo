using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTNelephant : MonoBehaviour
{
    public VirtualButtonBehaviour Vb;
    public Animation elephant;

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
        elephant.GetComponent<Animation>().Play();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        elephant.GetComponent<Animation>().Stop();
    }

}
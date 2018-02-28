using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRControllerInputManager : MonoBehaviour {

    [Header("Trigger and Grip inputs")]
    [SerializeField] private string trigger;
    [SerializeField] private string grip;

    [Header("For Testing")]
    [SerializeField] private GameObject hand;
    [SerializeField] private Color none = Color.gray, triggerColor = Color.blue, gripColor = Color.cyan;
    private Renderer rend;

	// Use this for initialization
	void Start () {
        rend = hand.GetComponent<Renderer>();

    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis(trigger) == 1.0)
        {
            rend.material.color = triggerColor;
        } else if (Input.GetAxis(grip) == 1.0)
        {
            rend.material.color = gripColor;
        } else
        {
            rend.material.color = none;
        }
    }
}

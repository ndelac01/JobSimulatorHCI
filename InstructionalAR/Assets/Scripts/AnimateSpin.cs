using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateSpin : MonoBehaviour
{
	public GameObject animateObj;
	//
	public float currentSpinAngleY;
	public float spinVelocity;
	
	// Start is called before the first frame update
    void Start()
    {
		
        
	}

    // Update is called once per frame
    void Update()
    {
        // change angle variable
		currentSpinAngleY = currentSpinAngleY + spinVelocity;
		// set rotation vector of gameobject
		animateObj.transform.localEulerAngles = new Vector3(animateObj.transform.localEulerAngles.x, currentSpinAngleY, animateObj.transform.localEulerAngles.z);
    }
}

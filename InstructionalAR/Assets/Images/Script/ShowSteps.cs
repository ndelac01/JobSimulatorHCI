using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSteps : MonoBehaviour
{
    public GameObject[] StepsObj;        // List of Game Objects
	public int currentStepNumber = 0;    // List Pointer of Current Step

	void hideAllSteps(){
		for (int i=0; i<StepsObj.Length; i++){ 
			StepsObj[i].SetActive(false);
		}
	}
	
	public void showNextStep(){	
		hideAllSteps();
		
		// increment step
		currentStepNumber = currentStepNumber + 1;
		if (currentStepNumber > StepsObj.Length -1){
			currentStepNumber = 0;
		}
		// show current step Game Object
		StepsObj[currentStepNumber].SetActive(true);
		
	}
	
	// Start is called before the first frame update
    void Start()
    {  
		hideAllSteps();
		StepsObj[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {  
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignTexture : MonoBehaviour
{
    public Texture selectTexture;
	public GameObject TextureObj;
	
	public void AssignTextureToObject(){
		Renderer RendererComponent = TextureObj.GetComponent<Renderer>();
		RendererComponent.material.SetTexture("_MainTex", selectTexture);
	}
}

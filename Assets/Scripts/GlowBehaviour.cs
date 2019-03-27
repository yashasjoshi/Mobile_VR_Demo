using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowBehaviour : MonoBehaviour {

    public Material glowMaterial;

    private Renderer myRenderer;
    private Material normalMaterial;

	// Use this for initialization
	void Start () {
        this.myRenderer = GetComponent<Renderer>();
        this.normalMaterial = this.myRenderer.material;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Highlight()
    {
        myRenderer.material = glowMaterial;
    }

    public void NormalRendering()
    {
        myRenderer.material = normalMaterial;
    }
}

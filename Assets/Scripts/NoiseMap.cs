using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseMap : PostEffectsBase {

	public Shader noiseMap;

	private Material noiseMaterial;
	public Material NoiseMaterial{
		get{ 
			noiseMaterial = CheckShaderAndCreateMaterial (noiseMap, noiseMaterial);
			return noiseMaterial;
		}
	}

	public Texture2D noise;

	[Range(0.0f, 10.0f)]
	public float intensity = 1.0f;
	[Range(0.0f, 10.0f)]
	public float frequency = 1.0f;

	// Use this for initialization
	void OnRenderImage(RenderTexture src, RenderTexture dest) {
		if (NoiseMaterial != null) {
			NoiseMaterial.SetTexture ("_Noise", noise);
			NoiseMaterial.SetFloat ("_Intensity", intensity);
			NoiseMaterial.SetFloat ("_Frequency", frequency);

			Graphics.Blit (src, dest, NoiseMaterial);
		} else {
			Graphics.Blit (src, dest);
		}
	}
}

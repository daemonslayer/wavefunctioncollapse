﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode, ImageEffectAllowedInSceneView]
public class UnderwaterEffects : MonoBehaviour
{
    public Material _mat;
    [Range(0.001f, 0.1f)]
    public float _pixelOffset;
    [Range(0.1f, 20.0f)]
    public float _noiseScale;
    [Range(0.1f, 30.0f)]
    public float _noiseSpeed;
    [Range(0.1f, 20.0f)]
    public float _noiseFrequency;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _mat.SetFloat("_NoiseFrequency", _noiseFrequency);
        _mat.SetFloat("_NoiseSpeed", _noiseSpeed);
        _mat.SetFloat("_NoiseScale", _noiseScale);
        _mat.SetFloat("_PixelOffset", _pixelOffset);
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, _mat);
    }
}
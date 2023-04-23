using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.VFX.Utility;


[RequireComponent(typeof(VisualEffect))]
public class VFXOutputEventTeleportObject : VFXOutputEventAbstractHandler
{

    static readonly int kPosition = Shader.PropertyToID("position");

    public override bool canExecuteInEditor => true;


    public override void OnVFXOutputEvent(VFXEventAttribute eventAttribute)
    {
        Debug.Log("Sound Event received");
        var tempAudioSource = GetComponent<AudioSource>();
        if (tempAudioSource != null)
        {
            tempAudioSource.Play();
        }
    }
}

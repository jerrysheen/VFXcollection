using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.VFX;

public class VFXTrigger : MonoBehaviour
{
    public GameObject vfxGo;

    private VisualEffect effect;
    // Start is called before the first frame update
    void Start()
    {
        effect = vfxGo.GetComponent<VisualEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayVFXOnce()
    {
        if(!effect)effect = vfxGo.GetComponent<VisualEffect>();
        effect.Play();
    }
}


[CustomEditor(typeof(VFXTrigger))]
public class VFXTriggerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        var script = target as VFXTrigger;
        if (GUILayout.Button("Play"))
        {
            script.PlayVFXOnce();
        }

    }
}
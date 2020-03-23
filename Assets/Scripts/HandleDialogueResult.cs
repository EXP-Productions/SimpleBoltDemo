using System;
using UnityEngine;
using PixelCrushers.DialogueSystem;
using Ludiq;
using Bolt;

public class HandleDialogueResult : MonoBehaviour
{   
    public FlowMachine _TargetFlowMachine;
    public string _TargetGraphVariableName;

    public string _DialogueLua_ResultName;


    void OnEnable()
    {
        string val = DialogueLua.GetVariable("UserChoice").asString;
        var graphReference = GraphReference.New(_TargetFlowMachine, true);
        Variables.Graph(graphReference).Set(_TargetGraphVariableName, val);
    }
}


using SofaUnity;
using Unity.VisualScripting;
using UnityEngine;

public class ToolCutActivateOnStart : MonoBehaviour
{
    [SerializeField] SofaLaserModel cutTool;

    void Start()
    {
        if (cutTool == null)
            cutTool = GetComponentInChildren<SofaLaserModel>();

        Invoke("ActivateTool", 2f);
    }

    void ActivateTool()
    {
        cutTool.m_drawRay = true;
        cutTool.DrawLaser = true;
        cutTool.DrawLight = false;
        cutTool.Length= 2.5f;
        cutTool.ActivateTool = true;
    }
}

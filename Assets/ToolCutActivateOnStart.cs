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

        Invoke("ActivateTool", 3f);
    }

    void ActivateTool()
    {
        cutTool.ActivateTool = true;
        cutTool.m_drawRay = false;
        cutTool.DrawLaser = false;
        cutTool.DrawLight = false;
        cutTool.Length= 9f;
        cutTool.RayWidth = 3f;
        cutTool.ActivateTool = true;
    }
}

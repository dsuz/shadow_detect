using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShadowUtility : MonoBehaviour
{
    public Text m_messsageText;

    public void OnEnterShadow()
    {
        Debug.Log("Enter Shadow");
        if (m_messsageText) m_messsageText.text = "Step on shadow";
    }

    public void OnExitShadow()
    {
        Debug.Log("Exit Shadow");
        if (m_messsageText) m_messsageText.text = "";
    }
}
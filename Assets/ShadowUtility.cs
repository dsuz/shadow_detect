using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShadowUtility : MonoBehaviour
{
    public Text m_messsageText;

    public void OnEnterShadow()
    {
        if (m_messsageText) m_messsageText.text = "影を踏んでいる";
    }

    public void OnExitShadow()
    {
        if (m_messsageText) m_messsageText.text = "";
    }
}
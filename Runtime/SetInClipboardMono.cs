using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInClipboardMono : MonoBehaviour
{
    
    public void PushInClipboard(string text)
    {
        GUIUtility.systemCopyBuffer = text;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class VersionText : MonoBehaviour
{
    Text version_text;
    // Start is called before the first frame update
    void Start()
    {
        version_text = GetComponent<Text>();
        version_text.text =  Application.version;
    }
}

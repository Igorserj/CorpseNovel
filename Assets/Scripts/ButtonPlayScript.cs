using Naninovel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlayScript : MonoBehaviour
{
    public void PlayNaninovelScript(string script)
    {
        var playScript = GetComponent<PlayScript>();
        playScript.Play(script);
    }

}

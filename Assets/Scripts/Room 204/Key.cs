using Naninovel;
using Naninovel.Commands;
using System;
using UnityEngine;
using UnityEngine.UI;

[CommandAlias("keyPicked")]
public class Key : Command
{
    public StringParameter IsKeyPicked;

    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        var button_image = GameObject.Find("Key_button").GetComponent<Image>();
        var button = GameObject.Find("Key_button").GetComponent<Button>();
        var key_image = GameObject.Find("Key_image").GetComponent<Image>();

        if (Assigned(IsKeyPicked))
        {
            button.enabled = !Convert.ToBoolean(IsKeyPicked);
            button_image.enabled = !Convert.ToBoolean(IsKeyPicked);
            key_image.enabled = !Convert.ToBoolean(IsKeyPicked);
        }

        return UniTask.CompletedTask;
    }
}

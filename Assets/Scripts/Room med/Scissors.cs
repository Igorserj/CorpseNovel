using Naninovel;
using System;
using UnityEngine;
using UnityEngine.UI;
using static Naninovel.Command;

[CommandAlias("scissorsPicked")]
public class Scissors : Command
{
    public StringParameter IsPicked;
    public StringParameter Hide;

    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        var back_button_image = GameObject.Find("Back_button").GetComponent<Image>();
        var back_button = GameObject.Find("Back_button").GetComponent<Button>();
        var back_text = GameObject.Find("BackLabel").GetComponent<Text>();

        var sci_button_image = GameObject.Find("Scissors_button").GetComponent<Image>();
        var sci_button = GameObject.Find("Scissors_button").GetComponent<Button>();

        if (Assigned(Hide))
        {
            if (Convert.ToBoolean(Hide) == true)
            {
                sci_button_image.enabled = false;
                sci_button.enabled = false;
            }
            else if (Assigned(IsPicked))
            {
                sci_button_image.enabled = !Convert.ToBoolean(IsPicked);
                sci_button.enabled = !Convert.ToBoolean(IsPicked);
            }
            else
            {
                sci_button_image.enabled = !Convert.ToBoolean(Hide);
                sci_button.enabled = !Convert.ToBoolean(Hide);
            }

            back_button.enabled = !Convert.ToBoolean(Hide);
            back_button_image.enabled = !Convert.ToBoolean(Hide);
            back_text.enabled = !Convert.ToBoolean(Hide);
        }

        return UniTask.CompletedTask;
    }
}

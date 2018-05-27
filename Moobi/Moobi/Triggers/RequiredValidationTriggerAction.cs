﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Moobi
{
    public class RequiredValidationTriggerAction : TriggerAction<Entry>
    {
        // This is the function that gets called when the specified event occurs in the trigger definition
        protected override void Invoke(Entry sender)
        {
            sender.BackgroundColor = string.IsNullOrEmpty(sender.Text) ? Color.FromHex("#FFCDD2") : Color.Default;
        }
    }
}

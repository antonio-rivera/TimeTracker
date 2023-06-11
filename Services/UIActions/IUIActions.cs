using System;
using Microsoft.AspNetCore.Components;

namespace TimeTracker.Services.UIActions
{
    public interface IUIActions
    {
        void ExpandTextArea(ChangeEventArgs e, ref string width, ref string height);
        void SetHeight(ChangeEventArgs e, ref string height);
        void SetWidth(ChangeEventArgs e, ref string width);
    }
}


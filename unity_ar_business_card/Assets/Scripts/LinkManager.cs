using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkManager : MonoBehaviour
{
    public void OpenLinkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/clintonhendrickson/");
    }

    public void OpenEmail()
    {
        Application.OpenURL("mailto:lessismoreclint@gmail.com");
    }

    public void OpenFaceBook()
    {
        Application.OpenURL("https://www.facebook.com/profile.php?id=61555141275827");
    }

    public void OpenGitHub()
    {
        Application.OpenURL("https://github.com/Maitreya-today");
    }
}
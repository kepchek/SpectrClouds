using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PoliceMenu : MonoBehaviour
{
    private string policykey = "policy";
    
    void Start()
    {
        var accepted = PlayerPrefs.GetInt(policykey, 0) == 1;
        if(accepted) return;
        SimpleGDPR.ShowDialog( new TermsOfServiceDialog().
				SetPrivacyPolicyLink( "https://drive.google.com/file/d/1G0pttqC1vCXqvwNJP1ShRIoRdU489OFO/view?usp=sharing" ),
				OnMenuClosed);
    }

    void OnMenuClosed()
    {
        Debug.LogWarning("PrivacyPolicyClosed");
        PlayerPrefs.GetInt(policykey, 1);
    }
}

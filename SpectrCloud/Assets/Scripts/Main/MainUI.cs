using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    public void BackButton()
    {
        SceneManager.LoadScene("HubScene");
    }
    public void PayButton()
    {
        Application.OpenURL(Payment.LinkButtonPay);
    }
}

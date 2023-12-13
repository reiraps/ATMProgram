using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deposit : MonoBehaviour
{
    public void OnDepositButtonClick()
    {
        SceneManager.LoadScene("DepositScene");
    }

    public void OnDepositButton1Click()
    {
        SceneManager.LoadScene("WithdrawalScene");
    }
    public void OnDepositButton2Click()
    {
        SceneManager.LoadScene("MainScene");
    }
}

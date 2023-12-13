using UnityEngine;
using UnityEngine.UI;

public class ATMWithdrawal : MonoBehaviour
{
    public Text balanceText;
    public Text totalAmountText;
    public Button transfer10000Button;
    public Button transfer30000Button;
    public Button transfer50000Button;

    public InputField depositAmountInputField;
    public Button depositInputButton;


    public GameObject popupPanel;
    public Button closePopupButton;

    private int totalAmount = 100000;
    private int balance = 50000;

    void Start()
    {
        transfer10000Button.onClick.AddListener(() => TransferAmount(10000));
        transfer30000Button.onClick.AddListener(() => TransferAmount(30000));
        transfer50000Button.onClick.AddListener(() => TransferAmount(50000));

        depositInputButton.onClick.AddListener(() => DepositAmountFromInput());

        closePopupButton.onClick.AddListener(ClosePopup);

        UpdateBalanceText();
        UpdateTotalAmountText();
    }

    void TransferAmount(int transferAmount)
    {
        if (transferAmount <= balance)
        {
            totalAmount += transferAmount;
            balance -= transferAmount;
            UpdateBalanceText();
            UpdateTotalAmountText();
        }
        else
        {
            ShowPopup("잔액이 부족합니다.");
        }
    }

    void DepositAmount(int depositAmount)
    {
        if (depositAmount <= balance)
        {
            balance -= depositAmount;
            totalAmount += depositAmount;
            UpdateBalanceText();
            UpdateTotalAmountText();
        }
        else
        {
            ShowPopup("잔액이 부족합니다.");
        }
    }

    void DepositAmountFromInput()
    {
        int depositAmount = int.Parse(depositAmountInputField.text);

        if (depositAmount <= totalAmount)
        {
            totalAmount += depositAmount;
            balance -= depositAmount;
            UpdateBalanceText();
            UpdateTotalAmountText();
        }
        else
        {
            ShowPopup("잔액이 부족합니다.");
        }
    }

    void UpdateBalanceText()
    {
        balanceText.text = $"{balance}";
    }
    void UpdateTotalAmountText()
    {
        totalAmountText.text = $"{totalAmount}";
    }
    void ShowPopup(string message)
    {
        popupPanel.SetActive(true);
    }
    void ClosePopup()
    {
        popupPanel.SetActive(false);
    }
}
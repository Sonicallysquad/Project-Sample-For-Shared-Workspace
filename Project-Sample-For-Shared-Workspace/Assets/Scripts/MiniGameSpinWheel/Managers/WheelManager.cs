using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace MiniGameSpinWheel { 

public class WheelManager : MonoBehaviour {

    //Creates the wheel
    SpinWheel wheel = new SpinWheel(8);
    int money = 300;
    public Text text;
    public GameObject go;
    public GameObject win;
    public Text winT;

    private void Awake()
    {
        PlayerPrefs.DeleteAll();
    }

    void Start() {
        //Keep track of the player money
        money = PlayerPrefs.GetInt("money", 3000);
        UpdateText();

        //Sets the gameobject
        wheel.setWheel(gameObject);

        //Sets the callback
        wheel.AddCallback((index) => {
            switch (index)
            {
                case 1:
                    money += 100;
                    PlayerPrefs.SetInt("money", money);
                    win.SetActive(true);
                    winT.text = "100";
                    break;
                case 2:
                    money += 500;
                    PlayerPrefs.SetInt("money", money);
                    win.SetActive(true);
                    winT.text = "500";
                    break;
                case 3:
                    money += 100;
                    PlayerPrefs.SetInt("money", money);
                    win.SetActive(true);
                    winT.text = "100";
                    break;
                case 4:
                    money += 100;
                    PlayerPrefs.SetInt("money", money);
                    win.SetActive(true);
                    winT.text = "100";
                    break;
                case 5:
                    money += 200;
                    PlayerPrefs.SetInt("money", money);
                    win.SetActive(true);
                    winT.text = "200";
                    break;
                case 6:
                    money += 100;
                    PlayerPrefs.SetInt("money", money);
                    win.SetActive(true);
                    winT.text = "100";
                    break;
                case 7:
                    money += 200;
                    PlayerPrefs.SetInt("money", money);
                    win.SetActive(true);
                    winT.text = "200";
                    break;
                case 8:
                    money += 300;
                    PlayerPrefs.SetInt("money", money);
                    win.SetActive(true);
                    winT.text = "300";
                    break;
            }
            UpdateText();
        });
    }

    public void UpdateText()
    {
        text.text = money + "";
    }

    public void OkWin()
    {
        win.SetActive(false);
    }

    public void Spin()
    {
        if (money >= 300)
        {
            money -= 300;
            PlayerPrefs.SetInt("money", money);

            StartCoroutine(wheel.StartNewRun());
            UpdateText();
        } else
        {
            go.SetActive(true);
        }
    }

    public void ok()
    {
        go.SetActive(false);
    }
 }
}

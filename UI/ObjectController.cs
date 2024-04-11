using Unity.VisualScripting;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    // 0 index always main menu.
    public GameObject ScreenmainMenu, ScreenNewGame, ScreenContinue, ScreenOptions;
    [SerializeField] private GameObject[] arrayScreen;
    [Space]
    public int ScreenValue = 0;

    private void Awake()
    {
        arrayScreen[0] = ScreenmainMenu;
        arrayScreen[1] = ScreenNewGame;
        arrayScreen[2] = ScreenContinue;
        arrayScreen[3] = ScreenOptions;
      
        ReturnToMainMenu();
    }

    public void ReturnToMainMenu()
    {
        arrayScreen[0].SetActive(true);
        arrayScreen[1].SetActive(false);
        arrayScreen[2].SetActive(false);
        arrayScreen[3].SetActive(false);
    }

    public void GoToScreen(int ScreenValue)
    {
        switch (ScreenValue)
        {
            case 0:
            default:
                ReturnToMainMenu();
                break;
            case 1:
            case 2:
            case 3:
                Fun1(ScreenValue);
                break;
        }
    }
    
    private void Fun1(int ScreenValue)
    {
        arrayScreen[0].SetActive(false); arrayScreen[ScreenValue].SetActive(true);
    }
}

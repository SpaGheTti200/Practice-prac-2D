using System.Collections;
using System.Collections.Generic;
using UI.MainMenu;
using UnityEngine;
using UScreens;

public class UIManager : MonoBehaviour
{
    private void Start()
    {
        UScreenRepo.Get<MainMenuController>().Show();
    }
}

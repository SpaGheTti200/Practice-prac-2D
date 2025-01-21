using MoreMountains.Feedbacks;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public static UIManager instance;

    public MMF_Player MmfShowPanel;
    public MMF_Player MmfHidePanel;

    private void Awake()
    {
        instance = this;
    }
}

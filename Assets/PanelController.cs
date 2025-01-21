using MoreMountains.Feedbacks;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    private MMF_Player mmf_PlayerShowPanel;
    private MMF_Player mmf_PlayerHidePanel;
    private MMF_Scale mmfScaleUp;
    private MMF_Scale mmfScaleDown;
    private MMF_SetActive mmfSetActiveTrue;
    private MMF_SetActive mmfSetActiveFalse;
    

    public void ShowPanel()
    {
        mmf_PlayerShowPanel = UIManager.instance.MmfShowPanel;
        mmfSetActiveTrue = mmf_PlayerShowPanel.GetFeedbackOfType<MMF_SetActive>();
        mmfScaleUp = mmf_PlayerShowPanel.GetFeedbackOfType<MMF_Scale>();

        
        mmfSetActiveTrue.TargetGameObject = this.gameObject;
        mmfScaleUp.AnimateScaleTarget = this.transform;
        
        mmf_PlayerShowPanel.PlayFeedbacks();

    }

    public void HidPanel()
    {
        mmf_PlayerHidePanel = UIManager.instance.MmfHidePanel;
        mmfScaleDown = mmf_PlayerHidePanel.GetFeedbackOfType<MMF_Scale>();
        mmfSetActiveFalse = mmf_PlayerHidePanel.GetFeedbackOfType<MMF_SetActive>(); 
        
        mmfSetActiveFalse.TargetGameObject = this.gameObject;
        mmfScaleDown.AnimateScaleTarget = this.transform;
        
        mmf_PlayerHidePanel.PlayFeedbacks();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;


public class AdPlayerAchievements : MonoBehaviour
{
  public void OpenAchievementPanel()
    {
        Social.ShowAchievementsUI();
    }

    public void UpdateIncremental()
    {
        PlayGamesPlatform.Instance.IncrementAchievement(GPGSIds.achievement_incremental_demo, 1, null);
    }

    public void UnlockRegular()
    {
        Social.ReportProgress(GPGSIds.achievement_first_ad_open, 100f, null);
    }
}

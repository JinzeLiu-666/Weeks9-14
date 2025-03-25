using UnityEngine;
using System.Collections;


public class LampFlasher : MonoBehaviour
{
    public LampController lampController;
    public FlashButton FlashButton;

    public bool isFlashing = false;

    public void StartFlashing()
    {
        // 只有灯是开着的，才能触发闪烁
        if (isFlashing == false)
        {
            isFlashing = true;
            StartCoroutine(FlashRoutine());
        }
    }

    IEnumerator FlashRoutine()
    {
        float timer = 0f;

        while (timer < 5f && lampController.isOn)
        {
            // 每0.5秒，切换 lightOverlay 的显示    状态
            bool currentState = lampController.lightOverlay.activeSelf;
            lampController.lightOverlay.SetActive(!currentState);

            yield return new WaitForSeconds(0.25f);
            timer = timer + 0.25f;
        }

        // 闪烁结束后，强制亮灯（你也可以改成 TurnOff()）
        lampController.lightOverlay.SetActive(false);
        isFlashing = false;
        FlashButton.TurnOff();
        lampController.TurnOff();
    }
}
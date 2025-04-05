using UnityEngine;
using System.Collections;


public class LampFlasher : MonoBehaviour
{
    public ToggleButton ToggleButton;
    private Coroutine flashCoroutine;
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

        while (timer < 5f && ToggleButton.isOn)
        {
            bool currentState = ToggleButton.lightOverlay.activeSelf;
            ToggleButton.lightOverlay.SetActive(!currentState);

            yield return new WaitForSeconds(0.25f);
            timer = timer + 0.25f;
        }

        ToggleButton.lightOverlay.SetActive(false);
        isFlashing = false;
        FlashButton.TurnOff();
        // lampController.TurnOff();
    }
}
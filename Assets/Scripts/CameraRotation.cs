using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform cameraPivot; // محور چرخش دوربین
    public float rotationSpeed = 100f; // سرعت چرخش

    private float totalRotation = 0f; // مجموع چرخش انجام شده

    void Update()
    {
        // اگر مجموع چرخش کمتر از 360 درجه باشد، دوربین بچرخد
        if (totalRotation < 360f)
        {
            // محاسبه چرخش
            float rotationAmount = rotationSpeed * Time.deltaTime;

            // چرخاندن محور دوربین
            cameraPivot.Rotate(0, rotationAmount, 0);

            // به‌روزرسانی مجموع چرخش
            totalRotation += rotationAmount;

            // اگر مجموع چرخش بیشتر یا مساوی 360 درجه شد، آن را تنظیم کنید
            if (totalRotation >= 360f)
            {
                totalRotation = 360f; // اطمینان از اینکه دقیقاً 360 درجه باشد
            }
        }
    }
}

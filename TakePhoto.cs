using UnityEngine;

public class TakePhoto : MonoBehaviour
{
    public bool takePhoto = false;
    public string photoName = "Screenshot.png";
    public int superSize = 1;

    // Update is called once per frame
    void Update()
    {
        if (takePhoto)
        {
            ScreenCapture.CaptureScreenshot(photoName, superSize);
            takePhoto = false;
        }
    }
}

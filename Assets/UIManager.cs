using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Biến lưu trữ panel Options để bật/tắt
    public GameObject optionsPanel;

    public void StartGame()
    {
        Debug.Log("Bắt đầu Game!");
        // Sau này bạn có thể dùng SceneManager.LoadScene("TênScene") ở đây
    }

    public void OpenOptions()
    {
        Debug.Log("Mở cài đặt!");
        if (optionsPanel != null)
        {
            optionsPanel.SetActive(true); // Hiển thị panel Settings
        }
    }

    public void ExitGame()
    {
        Debug.Log("Thoát Game!");
        Application.Quit(); // Chỉ hoạt động khi đã build game ra file exe/apk
    }
}
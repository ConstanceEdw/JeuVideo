using UnityEngine;
using UnityEngine.UI;

public class DeathManager : MonoBehaviour
{
    public GameObject true_player;
    public GameObject menu;
    public GameObject previous;
    public GameObject next;
    public Image displayImage;
    public Sprite[] imageArray;

    private int currentIndex = 0;
    private int camera_level = 0;
    private bool started = false;

    public void DeathScreen()
    {
        currentIndex = imageArray.Length - 1;
        UpdateDisplay();
        CameraUpdate();
        next.SetActive(false);
        previous.SetActive(false);
        this.enabled=false;
    }

    public void play()
    {
        CameraUpdate();
    }

    public void NextImage()
    {
        currentIndex = (currentIndex + 1) % imageArray.Length;
        UpdateDisplay();
    }

    public void PreviousImage()
    {
        if (currentIndex > 0)
        {
            currentIndex--;
            UpdateDisplay();
        }
    }
private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && started)
        {
            CameraUpdate();
        }
    }

    void UpdateDisplay()
    {
        if (imageArray.Length == 0) return;

        if (currentIndex == 3)
        {
            started = true;
            CameraUpdate();
        }

        displayImage.sprite = imageArray[currentIndex];
        previous.SetActive(currentIndex > 0);
    }

    void CameraUpdate()
    {
        camera_level++;

        if (camera_level % 2 == 0)
        {
            true_player.SetActive(false);
            menu.SetActive(true);
        }
        else
        {
            true_player.SetActive(true);
            menu.SetActive(false);
        }
    }
}
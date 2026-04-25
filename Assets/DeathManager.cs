using UnityEngine;
using UnityEngine.UI;
public class DeathManager : MonoBehaviour
{
    public static DeathManager Instance;

    public GameObject true_player;
    public GameObject menu;
    public GameObject previous;
    public GameObject next;
    public Image displayImage;
    public Sprite[] imageArray;

    private int currentIndex = 0;
    private int camera_level = 0;

    void Awake()
    {
        Instance = this;
    }

    public void TriggerDeath()
    {
        currentIndex = imageArray.Length - 1;
        UpdateDisplay();
        camera_update();
        next.SetActive(false);
        previous.SetActive(false);
        this.enabled=false;
    }

    void UpdateDisplay()
    {
        if (imageArray.Length > 0)
        {
            displayImage.sprite = imageArray[currentIndex];
        }
    }

    void camera_update()
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
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class death : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Collider Delete;
    private void OnTriggerStay(Collider other)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (other.gameObject.tag == "player")
                    {
                        death_screen();
                    }
            }
        }
    private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "player")
            {
                Delete = other;
                Destroy(Delete);
            }
        }
    public GameObject true_player;
    public GameObject menu;
    public GameObject previous;
    public GameObject next;
    private bool started=false;
    public void play()
    {
        camera_update();
    }
        public Image displayImage;   // Drag your UI Image here from the Hierarchy
        public Sprite[] imageArray; // Array to hold your sprites
        private int currentIndex = 0;


        public void NextImage()
        {
            // Cycle to the next index and wrap back to 0 if at the end
            currentIndex = (currentIndex + 1) % imageArray.Length;
            UpdateDisplay();

        }
        public void PreviousImage()
        {
            if (currentIndex!=0)
            {
                currentIndex = (currentIndex - 1) % imageArray.Length;
                UpdateDisplay();
            }
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (started==true)
                {
                    camera_update();
                }
            }
        }

        void UpdateDisplay()
        {
            if (imageArray.Length > 0)
            {
                if ((currentIndex % imageArray.Length)==3)
                {
                    started=true;
                    camera_update();
                }
                displayImage.sprite = imageArray[currentIndex];
                if (currentIndex>0)
                {
                    previous.SetActive(true);
                }
                else
                {
                    previous.SetActive(false);
                }
            }
        }
        private int camera_level=0;
        void camera_update()
        {
            Debug.Log(started);
            camera_level+=1;
            if (camera_level%2==0)
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
        void death_screen()
        {
            camera_level=imageArray.Length-1;
            UpdateDisplay();
            camera_update();


        }
}
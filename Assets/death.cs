using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class death : MonoBehaviour
{
    public GameObject use;
    private bool inTrigger;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Collider Delete;
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("left");
        use.SetActive(false);
        inTrigger=false;
    }
    private void OnTriggerStay(Collider other)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Supposed to die soon");
                if (other.gameObject.tag == "Player")
                    {
                        Debug.Log("Supposed to die");
                        death_screen();
                    }
            }
        }
    private void OnTriggerEnter(Collider other)
        {
            Debug.Log("in zone");
            use.SetActive(true);
            if (other.CompareTag("Player"))
            {
                inTrigger = true;
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
            if (inTrigger && Input.GetKeyDown(KeyCode.E))
            {
                death_screen();
            }
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
            currentIndex=(imageArray.Length-1);
            UpdateDisplay();
            camera_update();
            next.SetActive(false);
            previous.SetActive(false);
            this.enabled=false;


        }
}
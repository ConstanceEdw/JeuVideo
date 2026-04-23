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

                        Delete = other;
                        Destroy(Delete);
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
    public GameObject image_1;
    public void play()
    {
        true_player.SetActive(true);
        menu.SetActive(false);
        image_1.SetActive(false);

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

        void UpdateDisplay()
        {
            if (imageArray.Length > 0)
            {
                displayImage.sprite = imageArray[currentIndex];
            }
        }

}
using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Collider Delete;
    int Counter = 0;
    public GameObject[] LevelList;
    int ActiveLevel= 0;
    public GameObject endgame;
    // Update is called once per frame
    void Start()
    {

    }

    void Update()
    {
   
        if (Counter == 1)
            {
                NextLevel();
                Counter = 0;
            }

    }
     private void OnTriggerStay(Collider other)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (other.gameObject.tag == "ItemPick")
                    {
                       
                        Delete = other;
                        Destroy(Delete);
                        Counter += 1;
                    }
            }
        }
    private void NextLevel()
        {
            if (ActiveLevel+1< LevelList.Length)
                    {
                        LevelList[ActiveLevel].SetActive(false);
                        ActiveLevel++;
                        LevelList[ActiveLevel].SetActive(true);
                    }
            else
            {
                endgame.SetActive(true);
            }
        }
}
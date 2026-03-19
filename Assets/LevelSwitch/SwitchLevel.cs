using UnityEngine;

public class SwitchLevel : MonoBehaviour
{
    public GameObject[] LevelList;
    int ActiveLevel= 0;
    public GameObject endgame;
   

    void Start()
    {
        endgame.SetActive(false);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (ActiveLevel+1< LevelList.Length)
            {
                LevelList[ActiveLevel].SetActive(false);
                ActiveLevel++;
                LevelList[ActiveLevel].SetActive(true);
                Debug.Log(ActiveLevel);
                Debug.Log(LevelList.Length+" levelList");
            }
            else 
            {
                endgame.SetActive(true);
            }
           

        }
    }
}

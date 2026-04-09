using UnityEngine;

public class SwitchLevel : MonoBehaviour
{
    public GameObject[] LevelList;
    public GameObject[] positions;
    int ActiveLevel= 0;
    public GameObject endgame;
    public GameObject CubeSwitch;

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
                        gameObject.transform.position = positions[ActiveLevel].transform.position;
                        Debug.Log(LevelList.Length+" levelList");
                        CubeSwitch.SetActive(false);
                        if (other.gameObject.tag == "Change")
                            {
                            CubeSwitch = other.gameObject;
                            }
                    }
            else 
            {
                endgame.SetActive(true);
            }
           


        }
    }
}

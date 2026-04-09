using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject SwithCube;
    public GameObject[] Visuals;
    GameObject Delete;
    int Counter = 0;
    // Update is called once per frame
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            {
                if (Counter == 1)
                    {
                    
                    SwithCube.SetActive(true);
                    Destroy(Delete);
                    Counter = 0;
                    }
            }
    }
     private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "ItemPick")
                {
                 Delete = other.gameObject;
                 Counter++;
                }

        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "ItemPick")
                {
                Counter = 0;
                }
        }
}

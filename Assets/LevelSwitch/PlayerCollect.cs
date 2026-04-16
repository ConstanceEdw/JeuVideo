using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject SwithCube;
    public GameObject[] Visuals;
    Collider Delete;
    int Counter = 0;
    // Update is called once per frame
    void Start()
    {

    }

    void Update()
    {
    
        if (Counter == 2)
            {
                SwithCube.SetActive(true);
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
}

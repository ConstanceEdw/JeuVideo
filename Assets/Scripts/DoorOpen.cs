using UnityEngine;

public class DoorOpen : MonoBehaviour
{
bool IsDoorOpen = false;
public GameObject Door;

    void Start()
    {
        
    }
 private void OnTriggerStay(Collider other)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (other.gameObject.tag == "ItemPickDoor")
                    {
                        GameObject objectToDestroy = GameObject.FindGameObjectWithTag("Door_Gone");
                        Destroy(objectToDestroy);
                        Debug.Log("Destroyed");
                    }
            }
        }
    void Update()
    {    
     
   } 
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public int roomType;
    public void deleteRoom()
    {
        Destroy(gameObject);
    }
}

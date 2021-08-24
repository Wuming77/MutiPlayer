using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomsCanvases : MonoBehaviour
{
    [SerializeField]
    public CreatOrJoinRoomCanvas _creatOrJoinRoomCanvas;
    public CreatOrJoinRoomCanvas CreatOrJoinRoomCanvas { get { return _creatOrJoinRoomCanvas; } }

    [SerializeField]
    public CurrentRoomCanvas _currentRoomCanvas;
    public CurrentRoomCanvas CurrentRoomCanvas { get { return _currentRoomCanvas; } }

    private void Awake()
    {
        FirstInitialize();
    }

    private void FirstInitialize()
    {
        CreatOrJoinRoomCanvas.FirstInitialize(this);
        CurrentRoomCanvas.FirstInitialize(this);
    }
}

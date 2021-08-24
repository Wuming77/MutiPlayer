using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextNetwork : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("连接当中");
        PhotonNetwork.SendRate = 20;//20
        PhotonNetwork.SerializationRate = 5;//10
        AuthenticationValues authValues = new AuthenticationValues("1");
        PhotonNetwork.AuthValues = authValues;
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.NickName = MasterManager.GameSettings.NickName;
        PhotonNetwork.GameVersion = MasterManager.GameSettings.GameVersion;
        PhotonNetwork.ConnectUsingSettings();
    }

    // 连接服务器
    public override void OnConnectedToMaster()
    {
        Debug.Log("连接成功");
        Debug.Log(PhotonNetwork.LocalPlayer.NickName);
        if (!PhotonNetwork.InLobby)
            PhotonNetwork.JoinLobby();
    }
    
    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("和服务器断开连接的原因：" + cause.ToString());
    }
    
    public override void OnJoinedLobby()
    {
        Debug.Log("进入大厅");
    }
}

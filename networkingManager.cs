using UnityEngine;
using System.Collections;

public class networkingManager : Photon.MonoBehaviour {
	const string Version = "0.1";
	public string roomName = "VVR";
	public string playerPrefab = "3rd Person Controller";
	public Transform Spawn;


	void Start () {
		PhotonNetwork.ConnectUsingSettings (Version);
	}
	

	 void OnJoinedLobby()
	{

		RoomOptions roomOptions = new RoomOptions () {isVisible = false, maxPlayers = 4};
		PhotonNetwork.JoinOrCreateRoom(roomName,roomOptions,TypedLobby.Default);
	}
	void OnJoinedRoom()
	{

		PhotonNetwork.Instantiate(playerPrefab,Spawn.position,Spawn.rotation,0);
	}
}

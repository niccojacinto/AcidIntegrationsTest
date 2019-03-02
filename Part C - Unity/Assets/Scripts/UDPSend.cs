using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class UDPSend : MonoBehaviour {

    /// <summary>
    /// Simple datagram sender
    /// Sends information perhaps to Node.js to interface between MongoDB if mongoDB plugin is unavailable.
    /// </summary>

    string serverIP;
    int port = 8051;
    IPAddress ipAddress;
    IPEndPoint ipEndPoint;

    UdpClient client;

    private void Start() {
        InitServer();
    }

    void InitServer() {
        client = new UdpClient();
        ipAddress = IPAddress.Parse("127.0.0.1");
        ipEndPoint = new IPEndPoint(ipAddress, port);
    }

    public void SendUDPMessage(string message) {
        byte[] sendBytes = Encoding.ASCII.GetBytes(message);
        try
        {
            client.Send(sendBytes, sendBytes.Length, ipEndPoint);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }

    public void RequestDataFromDatabase() {
        throw new NotImplementedException();
    }

    /* Testing:
    IEnumerator KeepSendMessage() {
        while(true)
        {
            // Debug.Log(ViMicrophone.MicLoudness);
            SendUDPMessage(ViMicrophone.MicLoudness.ToString());
            yield return new WaitForSeconds(1.0f);
        }
    }
    */
}

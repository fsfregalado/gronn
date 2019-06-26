using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
public class Arduino : MonoBehaviour
{
    SerialPort ard;
    public string com = "COM1"; public int baudrate = 9600; public int sentido = 1;
    void Start()
    {
        ard = new SerialPort(com, baudrate); ard.Open();
        ard.ReadTimeout = 1000;
    }
    void Update()
    {
        if (ard.IsOpen)
        {
            try
            {
                string pot = ard.ReadLine();
                print(pot);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
    public void Close()
    {
        ard.Close();
    }
}
﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permission_to_Write_to_Registry
{
    internal class Program
    {
        static void Main(string[] args)
        {// Specify the Registry key and path
            string keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\YourSoftware";
            string valueName2 = "YourValueName";
            string valueData = "YourValueDataPermissinon";


            try
            {
                // Write the value to the Registry
                Registry.SetValue(keyPath, valueName2, valueData, RegistryValueKind.String);


                Console.WriteLine($"Value {valueName2} successfully written to the Registry.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}

/*

   Copyright 2016 Esri

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.

   See the License for the specific language governing permissions and
   limitations under the License.

*/
using System;
using System.Collections.Generic;
using System.Text;
using ESRI.ArcGIS.esriSystem;

namespace TestApp
{
  class Program
  {
    private static LicenseInitializer m_AOLicenseInitializer = new LicenseInitializer();

    [STAThread]
    static void Main(string[] args)
    {
      //ESRI License Initializer generated code.
      m_AOLicenseInitializer.InitializeApplication(new esriLicenseProductCode[] { esriLicenseProductCode.esriLicenseProductCodeEngine },
      new esriLicenseExtensionCode[] { });

      Console.WriteLine("Creating container object");
      //create a new instance of the test object which will internally clone our clonable object
      TestClass t = new TestClass();
      t.Test();

      Console.WriteLine("Done, hit any key to continue.");
      Console.ReadKey();

      //ESRI License Initializer generated code.
      //Do not make any call to ArcObjects after ShutDownApplication()
      m_AOLicenseInitializer.ShutdownApplication();
			
    }
  }
}

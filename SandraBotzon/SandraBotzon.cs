using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using System.Threading;
using OpenMetaverse;
using OpenMetaverse.Packets;
namespace MyBot{
  class SandraBotzon
  {
    public static void Main(string[] args){
       GridClient Client = new GridClient();
       LoginParams loginParams;
       loginParams = Client.Network.DefaultLoginParams(args[0],
                     args[1],args[2],"LearningMetaverses","1.0");
       
     
       while(true);

    }
  }
}

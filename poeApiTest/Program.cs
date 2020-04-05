
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;

namespace DemoLibrary
{
    class Program
    {
        public static string firstTry = "";
        static void Main(string[] args)
        {
            ApiHelper.InitializeClient();
            Console.WriteLine("Hello World!");
            Api funksjonen = new Api();
            Api.Funksjonen();
        }
        }
    }





//notater:
//    for å lage get funksjon må man ha en "public SunModel" "json navn" som funksjonen putter informasjonen inn i
//    så for poe må jeg lage data var for de aktuelle json objektene jeg skal putte inn i først.

//lager gjerne en egen klasse for "processing", også lurt å lage en generell funksjon for api get funksjon
// TODO: sjekk tips og triks for å lage / håndtere funksjons bibliotek på tvers av prosjekter. 
// TODO: lag mitt eget bibliotek med funksjoner for senere bruk.

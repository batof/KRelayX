﻿using System.Collections.Generic;
using System.Xml.Linq;

namespace Lib_K_Relay.GameData.DataStructures
{
    public struct ServerStructure : IDataStructure<string>
    {
        internal static Dictionary<string, ServerStructure> Load(XDocument doc)
        {
            var map = new Dictionary<string, ServerStructure>();

            doc.Element("Servers")
                .Elements("Server")
                .ForEach(server =>
                {
                    var s = new ServerStructure(server);
                    map[s.ID] = s;
                });

            return map;
        }

        public static readonly Dictionary<string, string> abbreviations = new Dictionary<string, string>
        {
            {"USWest", "USW"},
            {"USWest2", "USW2"},
            {"USWest3", "USW3"},
            {"USWest4", "USW4"},
            {"USMidWest", "USMW"},
            {"USMidWest2", "USMW2"},
            {"EUWest", "EUW"},
            {"USEast", "USE"},
            {"USSouth", "USS"},
            {"USSouth2", "USS2"},
            {"USSouthWest", "USSW"},
            {"EUEast", "EUE"},
            {"EUSouthWest", "EUSW"},
            {"USNorthWest", "USNW"},
            {"USSouth3", "USS3"},
            {"EUNorth", "EUN"},
            {"EUWest2", "EUW2"},
            {"EUSouth", "EUS"},
            {"EUEast2", "EUE2"},
            {"Asia", "A"},
            {"Australia", "AUS"}
        };

        /// <summary>
        ///     The complete name of this server
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     The abbreviation of this server
        /// </summary>
        public string Abbreviation;

        public string ID => Abbreviation;

        /// <summary>
        ///     The IP address of this server
        /// </summary>
        public string Address;

        public ServerStructure(XElement server)
        {
            Name = server.ElemDefault("Name", "");
            Abbreviation = abbreviations.ContainsKey(Name) ? abbreviations[Name] : "";
            Address = /*Dns.GetHostEntry(*/server.ElemDefault("DNS", "") /*).AddressList[0].ToString()*/;
        }

        public override string ToString()
        {
            return string.Format("Server: {0}/{1} ({2})", Name, Abbreviation, Address);
        }
    }
}
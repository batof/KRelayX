
# KRelayX - v1.0.0
## A modular Realm of the Mad God man-in-the-middle Proxy - RotMG version 2.0.4.1.0

This is an extended version of the [original KRelay project](https://github.com/TheKronks/KRelay) written by [Kronks#8312](https://github.com/TheKronks/KRelay) from [RealmStock](https://realmstock.com)

![Screenshot](https://i.imgur.com/SWNvEr1.png) 
-----------------------------------------------------------
## Features 🔥
- Connect to KRelayX with Exalt or a flash client and use custom written plugins to change game behaviour
- Injects a Proxy Server into the Exalt server list for easier connection, no Fiddler required
- Warns you in-game if KRelayX is running but you aren't connected to the Proxy Server
- Default plugins such as AutoNexus, AutoAbility, SpamStopper, TutorialMode and more.. see [Default Plugins](#default-plugins) for a full list
- *(coming soon)* - `Exalt custom DLL injection to allow for internal game hooking without a proxy` 
- *(coming soon)* - `Automatic updating by checking our game version against an API with the most recent version hash and downloading new XML files`

## Plugins 🔌  
`Lib-KRelayX` provides helper functions for hooking incoming/outgoing game packets, sending game packets and spoofing incoming server packets to the connected client.  
The [Plugins](https://github.com/abrn/KRelayX/tree/main/Plugins/) folder provides examples on plugins that have been written by numerous people and should serve as the best guide for creating your own.  

[The documentation file on writing plugins can be found here](https://github.com/abrn/KRelayX/tree/main/Plugins/README.md)  


## Default Plugins ⚡  
  
[Auto ability](https://github.com/abrn/KRelayX/tree/main/Plugins/AutoAbility)   
[Auto nexus](https://github.com/abrn/KRelayX/tree/main/Plugins/AutoNexus)   
[ClientStat announcer](https://github.com/abrn/KRelayX/tree/main/Plugins/ClientStatAnnouncer)  
[Rune finder](https://github.com/abrn/KRelayX/tree/main/Plugins/RuneFinder)  
[Spam stopper](https://github.com/abrn/KRelayX/tree/main/Plugins/SpamStopper)  
[Tutorial mode](https://github.com/abrn/KRelayX/tree/main/Plugins/TutorialMode)  
  
The [Plugins](https://github.com/abrn/KRelayX/tree/main/Plugins/)  folder contains a full list of default plugins which can be disabled via the GUI or deleted.

-----------------------------------------------------------

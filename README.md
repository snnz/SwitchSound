# SwitchSound

A tiny console tool for switching between audio output devices.

#### Run:

 - Without agruments - list devices with their interface identifiers.
   Currently active is marked with '*'.

 - With a list of interface identifiers as arguments - switch between devices in a circle: active -> next, last -> first.

#### For example:

```
> SwitchSound.exe

*S22E390 (HD Audio Driver for Display Audio)
 {0.0.0.00000000}.{24a8b3c5-8ece-48eb-9980-cf104f3ff711}

 Digital Audio (S/PDIF) (High Definition Audio Device)
 {0.0.0.00000000}.{42b8a793-61c3-430d-a214-d43c9b086421}

 Speakers (High Definition Audio Device)
 {0.0.0.00000000}.{a4a19331-61d9-46d4-8118-33c5003c1c20}


> SwitchSound.exe {0.0.0.00000000}.{24a8b3c5-8ece-48eb-9980-cf104f3ff711} {0.0.0.00000000}.{a4a19331-61d9-46d4-8118-33c5003c1c20}
> SwitchSound.exe

 S22E390 (HD Audio Driver for Display Audio)
 {0.0.0.00000000}.{24a8b3c5-8ece-48eb-9980-cf104f3ff711}

 Digital Audio (S/PDIF) (High Definition Audio Device)
 {0.0.0.00000000}.{42b8a793-61c3-430d-a214-d43c9b086421}

*Speakers (High Definition Audio Device)
 {0.0.0.00000000}.{a4a19331-61d9-46d4-8118-33c5003c1c20}


> SwitchSound.exe {0.0.0.00000000}.{24a8b3c5-8ece-48eb-9980-cf104f3ff711} {0.0.0.00000000}.{a4a19331-61d9-46d4-8118-33c5003c1c20}
> SwitchSound.exe

*S22E390 (HD Audio Driver for Display Audio)
 {0.0.0.00000000}.{24a8b3c5-8ece-48eb-9980-cf104f3ff711}

 Digital Audio (S/PDIF) (High Definition Audio Device)
 {0.0.0.00000000}.{42b8a793-61c3-430d-a214-d43c9b086421}

 Speakers (High Definition Audio Device)
 {0.0.0.00000000}.{a4a19331-61d9-46d4-8118-33c5003c1c20}
```

A typical usage is to create a shortcut with arguments to switch between selected devices and assign it to a hotkey.

# Csa témák
## Neurális hálózatok
### Hálók 1.0 revisited
Elemi neuron, lineáris kombináció, aktivációs függvények. Veszteségfüggvények, gradiens ereszkedés (Gradient Descent). Deriválás mátrixokkal, hibavisszaterjesztés (Backpropagation of errors). Anyag itt: https://github.com/csxeba/ANN_IQ
### Hálók 2.0
Softmax aktivációs függvény és kereszt-entrópia veszteségfüggvény (Cross Entropy). Neurális regresszió.
### Regularizáció
Túlillesztés (overfitting). L1 és L2 normák. Kiejtéses regularizáció (DropOut).
### Rekurzív Neurális Hálózatok 1.
Rekurzió. Hibavisszaterjesztés "az időn át" (Backpropagation Through Time, BPTT).
### Rekurzív Neurális Hálózatok 2.
Egyszerű RNN matematikája és implementációja. Gradiens "robbanás" (Exploding gradients). Brainforge könyvtár.
### Rekurzív Neurális Hálózatok 3.
Hosszú-rövid távó memória (LSTM) architektúra. Brainforge könyvtár.
### Konvolúciós Neurális Hálózatok
Konvolúció és kereszt-korreláció. Többdimenziós tenzorok. CNN matematikája és implementációja. Keras OO API.
### Trükkös architektúrák
Sztráda-architektúra (Highway Network. Autoencoder. Keras funkcionális API.

## Más gépi tanulás
### Mátrix-dekompozíciók
Egyenértékek, egyenvektorok, egyendekompozíció. Szinguláris érték dekompozíció (SVD). Főkomponens-analízis (PCA). NumPy - Linalg modul
### Kernel módszer 1.
Dualitás. Langrange-szorzó. Kernel függvények, kernel trükk.
### Kernel módszer 2.
Lineáris regresszió és duális problémája. Ridge regresszió és duális problémája.
### Kernel módszer 3.
Támasztóvektor-gép (Support Vector Machine, SVM). "Hinge" veszteségfüggvény. Scikit-Learn könyvtár.
### Evolúció - Genetikus algoritmus
Populációs és egyed. Evolúciós operátorok: szelekció, szaporodás, mutáció, crossing-over.
### Neuroevolúció
Hiperparaméterek evolúciója. Paraméterek (súlyok) evolúciója. Architektúra evolúciója, NEAT (Neuroevolution of Augmenting Topologies), HyperNEAT. MarI/O.

## Megerősítéses tanulás
### Alapok
Markov döntési folyamat, Markov-lánc (Markov decision process, Markov-chain). SARSA modell. Idődifferencia-modell (Temporal difference, TD). "Credit assignement", jutalom leszámítása (discount rewards). Felfedezés-hasznosítás (Exploration-Exploitation) dilemma. OpenAI Gym keretrendszer.
### Q-tanulás
Q-függvény, labirintus-probléma megoldása mátrix módszerrel. Bellman-függvény
### PG - Policy Gradients
"Pong from pixels" implementáció. Tapasztalat-visszajátszás. Atari Pong környezet.
### DQN - Deep Q Network
Q-függvény becslése neurális hálózattal. Bellman-függvény, mint veszteségfüggvény. Target hálózat. CartPole környezet.
### DDPG - Deep Deterministic Policy Gradients
Cselekvő-kritikus architektúra, a fenti koncepciók egyesítése. TORCS autóverseny környezet.

# Misi témák
## Kotlin
### Introduction to Kotlin
A nyelv alapjainak bemutatása. A szintaxis és nyújtott eszközök megismerése.
## Clean code
### libreplicator
A könyvtár bemutatása. A design-t befolyásoló döntések, levont tapasztalatok. (SOLID, modularization, dependency injection, ... TBD)

# Márk témák
## C#
### C# alapok + .NET Core
C# alapok (szintaxis, System libraryk + nuget, containerek, többszálas kezelés, IO, stb...) + .NET Core alapok (a projekt felépítése, hogyan lehet és milyen platformokra, .NET Standard)
### C# haladóknak
Stack, heap, garbage collector, reflection, generic osztályok, marshalling, pinvoke, stb...
### C# Java-s szemmel
Mi az amiben más a C#, mint a Java? Bár managelt mindkét nyelv és alapjaiban hasonló módszerrel műküdnek, sok kis és nagy különbség van közöttük.
### C# socketek
Blocking, non-blocking, async, csomagkezelés, csomagküldés, protokolok, packetek összeállítása, bitmágia az adat csökkentésére, stb...
### C# mint szerver
Szerver felépítése C#-ban. Előnyök, hátrányok, C# vs C++, stb...
## Reverse Engineering
### RE alapok (lehet hogy belefér 1 alkalomba a gyakorlati RE-vel együtt)
Definíció, típusok, programok; függvények, struktúrák, virtuális táblák, import és export táblák.
### Gyakorlati RE
Ismeretlen fájltípusok struktúrájának feltörése, titkosítás feltörése, socket kommunikáció struktúrájának megismerése, stb...
### Assembly alapok
Opkódok, stack, heap, regiszterek, NASM, RE asm olvasással, stb...

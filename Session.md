# Csa témák
## Neurális hálózatok
### Hálók 1 revisited
Elemi neuron, aktivációs függvények. Veszteségfüggvények, gradiens ereszkedés (Gradient Descent). Parciális deriválás mátrixokkal, hibavisszaterjesztés (Backpropagation). Kézzel írott számjegyek (MNIST adatsor) felismerése teljesen kapcsolt hálóval. Anyag itt: https://github.com/csxeba/ANN_IQ
### Hálók 2
**Dependencia: Hálók 1**

Osztályozás, regresszió, generatív modellek. Softmax aktivációs függvény és kereszt-entrópia veszteségfüggvény (Cross Entropy). Teljesítmény javítása az MNIST adatsoron.
### Regularizáció
**Dependecia: Hálók 2**

Túlillesztés (overfitting). L1 és L2 normák. Kiejtéses regularizáció (DropOut).
### Rekurrens Neurális Háló
#### RNN 1 (Recurrent Neural Network)
**Dependencia: Hálók 2**

Rekurzió, rekurrencia, visszacsatolás. Hibavisszaterjesztés "az időn át" (Backpropagation Through Time, BPTT). Szekvenciális adatok feldolgozása. Beágyazás (embedding).
#### RNN 2
**Dependencia: RNN 1**

Egyszerű RNN matematikája és implementációja. Gradiens "robbanás" (Exploding gradients). Brainforge könyvtár. *Petőfi Sándor bot*.
#### RNN 3
**Dependencia: RNN 2**

Hosszú-rövid távó memória (LSTM) architektúra. Brainforge könyvtár. *Python coder bot*.
#### NTM (Neural Turing Machine) és DNC (Differential Neural Computer)
**Dependencia: RNN 3**

Neurális Turing-gép. Külső elérésű memóriaegység. Differenciálható R/W memóriaműveletek. Differenciálható figyelem-mechanizmusok (attention). *Python script futtatása neurális turing gépeken*.
### Konvolúciós Neurális Háló (CNN)
**Dependencia: Hálók 2**

Konvolúció és kereszt-korreláció. Többdimenziós tenzorok. CNN matematikája és implementációja. Keras OO API. *MNIST CNN feldolgozása*.
### Trükkös architektúrák
**Dependencia: Hálók 2**

Sztráda-architektúra (Highway Network). Autoencoder. Keras funkcionális API.
### Deep Learning könyvtárak és automata differenciáló motorok Pythonhoz
**Dependencia: Hálók 2**

Mert deriválgasson akinek két anyja van. Tensorflow (by Google) vagy Theano (by University of Montréal).

## Más gépi tanulás
### Mátrix-dekompozíciók
Egyenértékek, egyenvektorok, egyendekompozíció. Szinguláris érték dekompozíció (SVD). Főkomponens-analízis (PCA). NumPy - Linalg modul.
### Kernel módszer 1
**Dependencia: Mátrix-dekompozíciók**

Dualitás. Langrange-szorzó. Kernel függvények, kernel trükk.
### Kernel módszer 2
**Dependencia: Kernel módszer 1**

Lineáris regresszió és duális problémája. Ridge regresszió és duális problémája.
### Kernel módszer 3
**Dependencia: Kernel módszer 2**

Támasztóvektor-gép (Support Vector Machine, SVM). "Hinge" veszteségfüggvény. Scikit-Learn könyvtár.
### Evolúció - Genetikus algoritmus
Populációs és egyed. Evolúciós operátorok: szelekció, szaporodás, mutáció, crossing-over.
### Neuroevolúció 1 - töltött zsemle szint
**Dependencia: Evolúció - Genetikus algoritmus**

Hiperparaméterek evolúciója. Paraméterek (súlyok) evolúciója.
### Neuroevolúció 2 - marha ribeye steak szint
**Dependencia: Evolúcuó - Genetikus algoritmus**

Architektúra evolúciója, NEAT (Neuroevolution of Augmenting Topologies), HyperNEAT + MarI/O (NES Super Mario bot).

## Reinforcement Learning - Megerősítéses tanulás
### RL alapok
Markov döntési folyamat, Markov-lánc (Markov decision process, Markov-chain). SARSA modell. Idődifferencia-modell (Temporal difference, TD). "Credit assignement", jutalom leszámítása (discount rewards). Felfedezés-hasznosítás (Exploration-Exploitation) dilemma. OpenAI Gym keretrendszer.
### Q-tanulás
**Dependencia: RL alapok**

Q-függvény, labirintus-probléma megoldása mátrix módszerrel. Bellman-függvény
### PG - Policy Gradients
**Dependencia: RL alapok**

Tapasztalat-visszajátszás. Atari Pong környezet, *Pong bot*.
### DQN - Deep Q Network
**Dependencia: Q-tanulás**

Q-függvény becslése neurális hálózattal. Bellman-függvény, mint veszteségfüggvény. Double Deep Q Network. CartPole környezet, *CartPole bot*.
### DDPG - Deep Deterministic Policy Gradients
**Dependecia: DQN, PG**

Cselekvő-kritikus architektúra, DQN és PG koncepciók egyesítése. TORCS autóverseny környezet, *TORCS bot*

## Python
### Python és adatbányászati alapok
Adattípusok. Ciklusok. Függvények. Osztályok, objektumok. NumPy ndarray. NumPy linalg. Scipy. Pandas dataframe.
### Python advanced
Generátorok (yield), generátor korutinok (yield expression, yield from), valódi korutinok (async/await). List/dict/set comprehension. Egysoros if/else. Metaclass. Operátor overloading (magic metódusok). Dekorátorok.

## Tudomány
### Tudományos módszertan
Megfigyelés, hipotézisfelállítás, kísérletezés, kiértékelés. Szakirodalom felkutatása és hozzáférés megszerzése.

### Low level kémia
Atomi és molekuláris szint.

### Biokémia dietetikus szemmel
Fő vegyületcsoportok. Miből mennyit és miért. Mivel mi lesz. Szénhidrátok, zsírok, fehérjék, nukleinsavak.

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
## PHP
### Yii2 Framework
Composer + csomagok, MVC, ActiveRecord, formkezelés, kontrollerek, stb...
Miért jó a PHP? Miért nem jó a PHP?

# Hege témák

## Coded UI
C# teszt automatizálás

## Modern C++
11-14-17 szabványok, mi hogyan változott.

## C++ állásinterjú tesztek, kérdések

# Robi témák
## Unity alapok

# MiPrimerTerreno
Desarrollo de terrenos y programación del movimiento de un cubo en Unity
# Navegación de la escena

## Cómo ejecutar la escena

1. Abrir el proyecto en :contentReference[oaicite:0]{index=0}.
2. Abrir la escena `SampleScene`.
3. Presionar el botón **Play** ubicado en la parte superior del editor.

## Cómo abrir el proyecto

1. Abrir Unity Hub.
2. Seleccionar "Add" o "Open".
3. Elegir la carpeta principal del proyecto (la carpeta que contiene `Assets`, `Packages` y `ProjectSettings`).
4. Abrir la escena `SampleScene`.
5. Presionar Play.

## Objetivo de la escena

El jugador controla a Hello Kitty y puede recorrer el mapa, explorar el terreno y observar los distintos objetos distribuidos en la escena, como árboles, flores, hongos, rocas, cofres y lanzaguisantes.

## Controles del jugador

Hello Kitty es el único personaje controlable de la escena.

### Movimiento

- `W` o flecha ↑ : avanzar
- `S` o flecha ↓ : retroceder
- `A` o flecha ← : avanzar hacia la izquierda
- `D` o flecha → : avanzar hacia la derecha

El personaje gira suavemente en la dirección del movimiento.

### Salto

- `Espacio` : saltar

El salto solo funciona cuando Hello Kitty está tocando el suelo.

## Objetos presentes en la escena

La escena contiene los siguientes elementos principales:

- Terreno (`Terrain`)
- Árbol de abedul (`Birch Tree`)
- Árbol caducifolio (`Deciduous Tree`)
- Roble (`Oak Tree`)
- Flores (`Flower`)
- Césped (`Grass`)
- Rocas (`Rock`)
- Hongos (`Mushroom`)
- Cofre (`Cofre`)
- Lanzaguisantes (`Lanzaguisantes`)
- Personaje principal (`HelloKitty`)

## Cámara

La cámara sigue automáticamente a Hello Kitty durante el recorrido de la escena.

## Requisitos

Para que el movimiento funcione correctamente, el proyecto debe tener habilitado el paquete de entrada de :contentReference[oaicite:1]{index=1}.

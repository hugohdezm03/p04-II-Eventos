# Interfaces Inteligentes

- Hugo Hernández Martín (alu0101481227@ull.edu.es)

# Práctica 4: Introducción a los Eventos. Patrón Observador.

## Actividad 1

Se ha creado una escena en la que se añade un cubo cinemático, un cilindro físico perfecto y dos grupos de dos esferas (todas ellas físicas perfectas). El cubo se puede controlar mediante las teclas aswd o las flechas. Cuando el cubo choca contra el cilindro (***onCollisionEnter***), las esferas del grupo 2 se desplazan hacia el cilindro y las del grupo 1 hacia la posición media de las del grupo dos (se toma la posición de ambas esferas del grupo 1, se suman y se divide entre dos). Es importante destacar que las esferas han de ser movidas mediante fuerzas, ya que son físicas perfectas. Por último, se ha implementado mediante un patrón observador (el cilindro es el notificador que detecta la colisión con el cubo y las esferas son los suscriptores, que reaccionan cuando reciben el evento).

* Esferas Grupo 1 (color amarillo).
* Esferas Grupo 2 (color naranja).

![GIF actividad 1](./docs/p04_II_actividad_01.gif)

[Enlace al Script de movimiento del cubo.](./Scripts/PlayWithObject.cs)

[Enlace al Script Notificador.](./Scripts/CollisionNotifier.cs)

[Enlace al Script esferas grupo 1.](./Scripts/MoveToGroup2SpheresWhenCubeCollision.cs)

[Enlace al Script esferas grupo 2.](./Scripts/MoveToCylinderWhenCubeCollision.cs)

## Actividad 2

Se sustituyen las esferas y los cilindros por arañas y huevos de arañas respectivamente. Se añade un huevo para que haya uno de cada tipo de araña.

![Foto actividad 2](./docs/p04_II_actividad_02.png)
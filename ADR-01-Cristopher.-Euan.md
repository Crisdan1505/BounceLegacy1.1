# ADR-01: [Uso de Unity y arquitectura modular basada en componentes.]

| Campo  | Valor |
|--------|-------|
| Autor  | [Cristopher M. Euan Pool] |
| Fecha  | 05/06/2026 |
| Estado | `Propuesto` · `Aceptado` · `Rechazado` · `Reemplazado por ADR-NN` |

---

## Contexto

Estoy construyendo Bounce Legacy, un videojuego de plataformas 2D inspirado en juegos retro, donde el jugador controla a un personaje tipo esfera que puede moverse, saltar, recolectar Legacy Crystals, enfrentarse a enemigos, avanzar por niveles con puntos de guardado y de RESPOWN.

El proyecto está dirigido al público gamer casual y a personas que disfrutan los videojuegos de plataformas con físicas simples, exploración y mecánicas progresivas o del un videojuego sencillo pero entretenido como los clasicos un emeplo Metal Slug un juego plataformero sencillo pero entretenido.

El problema que busca resolver es ofrecer una experiencia de juego sencilla, entretenida y nostálgica, evitando que el proyecto se vuelva difícil de mantener conforme se agreguen nuevas mecánicas como enemigos, cristales, respawn, UI, transformaciones y guardado.

Las condiciones que influyeron en esta decisión fue el querer crear algo a la vieja escuela de sencillo pero entretenido tomando en cuenta la nostalgia de los juego anteriores sin la necesidad de ser tan complejos para ser entretenidos, el uso de tecnologías relacionadas con C#, La compatibilidad entre Visual Community y Unity, y la importancia de mantener el código organizado desde el inicio para este poder ir creciendo manteniendo un facil mantenimiento.
---

## Decisión

Se decidió utilizar Unity como motor de desarrollo gracias a que es mas intuitivo,ademas de este permitir conectar mi proyecto con Visual Studio Community, C# como lenguaje de programación y una arquitectura modular basada en componentes.

El sistema se organizará en módulos separados, por ejemplo:

* Player System
* Enemy System
* Camera System
* Collectibles System
* UI System
* Respawn System
* Save System

Cada script tendrá una responsabilidad específica dentro del videojuego evitando la creación de clases dios.
### ¿Por qué?
Se eligió Unity porque facilita el desarrollo de videojuegos 2D mediante herramientas integradas para físicas, colisiones, escenas, objetos, cámaras y UI.

La arquitectura modular basada en componentes permite separar responsabilidades. Por ejemplo, el movimiento del jugador se maneja en PlayerController, la cámara en CameraFollow, los enemigos en EnemyPatrol, los cristales en LegacyCrystal y el contador en GameManager.

Esto resuelve el problema de tener todo el código mezclado en un solo archivo. Además, facilita agregar nuevas funciones sin afectar directamente otros sistemas del juego.
### Alternativas consideradas


| Alternativa | Por qué la descarté |
|-------------|---------------------|
|Godot Engine        | Aunque es ligero y bueno para 2D, se descartó porque el proyecto ya trabaja mejor con C# y Unity ofrece mayor cantidad de recursos, documentación y soporte para principiantes.                |
| Unreal Engine        | Se descartó porque está más enfocado en proyectos 3D de alta calidad gráfica y sería demasiado pesado para un videojuego 2D sencillo.                |
| Crear el juego solo con C# sin motor gráfico        | Se descartó porque implicaría programar manualmente físicas, colisiones, renderizado y manejo de escenas, aumentando demasiado el tiempo de desarrollo.                 |
|Usar una arquitectura monolítica             | Se descartó porque implicaría programar manualmente físicas, colisiones, renderizado y manejo de escenas, aumentando demasiado el tiempo de desarrollo.                   |

---

## Consecuencias

**✅ Lo que gano:**

*Consecuencia técnica:*
El sistema se vuelve más fácil de mantener y escalar, ya que cada parte del videojuego está separada por responsabilidad. Esto permite modificar el sistema de enemigos, cristales, UI o jugador sin alterar todo el proyecto facilitando el realizar modificaciones o agregar mas cosas en el futuro.

*Consecuencia sobre el proceso:*
La organización por carpetas y scripts facilita trabajar de forma ordenada, documentar avances, subir cambios a GitHub y explicar mejor la arquitectura durante la defensa del proyecto.

**⚠️ Lo que sacrifico o asumo:**

Limitación técnica:
Al usar varios componentes y scripts, el proyecto requiere mayor organización. Si no se nombran bien los archivos o no se documenta, puede volverse confuso.

Deuda o riesgo:
Algunas soluciones iniciales pueden necesitar refactorización más adelante. Por ejemplo, la detección de suelo, el sistema de daño o el guardado podrían necesitar mejoras si el juego crece con más niveles, enemigos y transformaciones.
## Diagrama

<img width="518" height="723" alt="image" src="https://github.com/user-attachments/assets/178b30ff-59da-47e0-8776-bd20f3218c3b" />


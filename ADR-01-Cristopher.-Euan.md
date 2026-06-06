# ADR-01: [Título corto de la decisión]

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

*(Mínimo 3 filas)*

| Alternativa | Por qué la descarté |
|-------------|---------------------|
| ...         | ...                 |
| ...         | ...                 |
| ...         | ...                 |

---

## Consecuencias

**✅ Lo que gano:**

Menciona al menos:
- Una consecuencia **técnica** — qué se vuelve más fácil de construir, mantener o escalar en tu sistema
- Una consecuencia sobre el **proceso o el equipo** — cómo afecta la forma en que vas a trabajar

**⚠️ Lo que sacrifico o asumo:**

Menciona al menos:
- Una **limitación técnica** — qué no podrás hacer fácilmente con esta decisión
- Una **deuda o riesgo** — qué podrías tener que resolver más adelante si el proyecto crece

## Diagrama

Un boceto de cómo se estructura tu sistema (draw.io, Mermaid o a mano escaneado)

![Diagrama del sistema]( ./ruta/diagrama-nivel-1.png )

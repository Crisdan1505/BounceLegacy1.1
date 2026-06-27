# ADR-03: Uso de Arquitectura en Capas para Bounce Legacy

| Campo  | Valor                       |
| ------ | --------------------------- |
| Autor  | Cristopher Maximiliano Euan |
| Fecha  | 12/06/2026                  |
| Estado | Aceptado                    |

## Contexto

Bounce Legacy es un videojuego de plataformas 2D desarrollado en Unity. El proyecto incluye sistemas de movimiento del jugador, enemigos, coleccionables (Legacy Crystals), interfaz gráfica y futuros mecanismos de guardado mediante archivos JSON.

A medida que el proyecto crece, es necesario organizar el código de forma que sea fácil de mantener, ampliar y comprender. Además, el desarrollo se realiza por una sola persona y dentro de un tiempo limitado, por lo que se requiere una estructura clara que facilite la incorporación de nuevas funcionalidades.

## Decisión

Se decidió utilizar una **Arquitectura en Capas (Layered Architecture)**.

La aplicación se divide en las siguientes capas:

* Capa de Presentación (UI)
* Capa de Lógica de Juego
* Capa de Gestión del Estado
* Capa de Persistencia (futuro sistema JSON)

Cada capa tiene responsabilidades específicas y se comunica con las capas adyacentes.

## ¿Por qué?

La arquitectura en capas permite separar claramente las responsabilidades del sistema.

La interfaz gráfica se encarga únicamente de mostrar información al jugador. La lógica de juego administra mecánicas como movimiento, enemigos y coleccionables. El GameManager centraliza el estado global del juego y, en el futuro, la persistencia permitirá guardar el progreso mediante archivos JSON.

Esta separación facilita el mantenimiento, la reutilización de componentes y la escalabilidad del proyecto.

## Alternativas consideradas

| Alternativa            | Por qué la descarté                                                                                                 |
| ---------------------- | ------------------------------------------------------------------------------------------------------------------- |
| Microservicios         | Demasiado compleja para un videojuego local y de un solo jugador.                                                   |
| Cliente-Servidor       | No existe comunicación en red ni funcionalidades multijugador.                                                      |
| Event-Driven           | Aunque algunos eventos existen dentro de Unity, agrega complejidad innecesaria para el alcance actual del proyecto. |
| Arquitectura Hexagonal | Proporciona gran flexibilidad, pero resulta excesiva para un proyecto académico de tamaño pequeño.                  |

## Consecuencias

### ✅ Lo que gano

**Consecuencia técnica:**
El código se mantiene organizado y facilita la incorporación de nuevas funcionalidades como transformaciones, nuevos enemigos o sistemas de guardado.

**Consecuencia sobre el proceso:**
La estructura es más fácil de documentar, explicar y mantener durante el desarrollo del proyecto.

### ⚠️ Lo que sacrifico o asumo

**Limitación técnica:**
Algunas interacciones pueden requerir pasar información entre varias capas antes de llegar al componente que la necesita.

**Deuda o riesgo:**
Si el proyecto crece considerablemente, algunas responsabilidades podrían concentrarse demasiado en GameManager y requerir refactorización futura.

## Diagrama

El sistema se organiza mediante capas donde cada nivel consume los servicios del nivel inferior.
Diagrama creado en Mermaid.
<img width="917" height="610" alt="image" src="https://github.com/user-attachments/assets/d1a88fe3-9527-4ec8-8994-04365e883df5" />


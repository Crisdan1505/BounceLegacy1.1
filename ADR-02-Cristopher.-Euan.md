# ADR-01: [Título corto de la decisión]

| Campo  | Valor |
|--------|-------|
| Autor  | [Cristopher M. Euan Pool] |
| Fecha  | 05/06/2026 |
| Estado | `Propuesto` · `Aceptado` · `Rechazado` · `Reemplazado por ADR-NN` |

---

## Contexto

A medida que Bounce Legacy crece en funcionalidades, es necesario representar la arquitectura desde diferentes perspectivas para comprender mejor la estructura interna del sistema, la interacción entre componentes, la ejecución de procesos y el entorno donde será desplegado.

El proyecto incorpora múltiples módulos como movimiento del jugador, enemigos, sistema de coleccionables, interfaz gráfica y futuros mecanismos de guardado mediante archivos JSON.

---

## Decisión

Se decidió utilizar las siguientes vistas arquitectónicas:

Vista lógica
Vista física
Vista de despliegue
Vista de procesos

Estas vistas permiten documentar de manera clara la organización del sistema y facilitan futuras ampliaciones.

### ¿Por qué?

Cada vista permite observar una parte diferente del sistema:

La vista lógica muestra la organización funcional.
La vista física muestra la estructura de archivos y componentes.
La vista de despliegue representa dónde se ejecuta el sistema.
La vista de procesos describe la interacción entre módulos durante la ejecución.

Esto facilita la comprensión, mantenimiento y evolución del proyecto.

## Consecuencias

**✅ Lo que gano:**

* Mejor documentación del sistema.
* Mayor facilidad para explicar la arquitectura.
* Identificación más clara de responsabilidades.

**⚠️ Lo que sacrifico o asumo:**

Menciona al menos:
* Mayor esfuerzo de documentación.
* Los diagramas deberán mantenerse actualizados conforme crezca el proyecto.

## Diagrama
-Primer Diagrama.
<img width="514" height="705" alt="image" src="https://github.com/user-attachments/assets/4c8c1cde-319a-48c9-8bb7-eb2ca023d6b4" />

-Vista Logica.
<img width="544" height="504" alt="image" src="https://github.com/user-attachments/assets/8514b30b-4fe7-41f7-870f-6cf296e32ec7" />

-Vista física
<img width="413" height="735" alt="image" src="https://github.com/user-attachments/assets/3fdf2966-6ce3-49c2-88f4-0775192894cb" />

-Vista de despliegue
<img width="335" height="454" alt="image" src="https://github.com/user-attachments/assets/18712871-e427-4054-afff-b62afc876acb" />

-Vista de procesos
<img width="312" height="724" alt="image" src="https://github.com/user-attachments/assets/d5e6eaac-6af8-4f44-bd28-88f78bba9b65" />






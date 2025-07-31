# 🧠 Proyecto Notificador - Principios SOLID en C#

Este proyecto es una implementación simple de un sistema de notificaciones utilizando los **principios SOLID** del desarrollo orientado a objetos en C#.

## 📌 Objetivo

Aplicar correctamente los principios SOLID para mejorar la mantenibilidad, escalabilidad y claridad del código a través de una estructura desacoplada y orientada a interfaces.

---


---

## 📐 Principios SOLID Aplicados

### 🔹 S – Single Responsibility Principle
- Cada clase tiene **una única responsabilidad**: enviar una notificación o guardar un log.
- `ServicioNotificacion` se encarga solo de orquestar.

### 🔹 O – Open/Closed Principle
- El sistema es **extensible sin modificar el código existente**. Se pueden agregar nuevos notificadores sin tocar el resto del sistema.

### 🔹 L – Liskov Substitution Principle
- Las implementaciones concretas pueden ser **sustituidas por sus interfaces** sin afectar el comportamiento general del sistema.

### 🔹 I – Interface Segregation Principle
- Las interfaces son **específicas**. Cada clase implementa solo lo que necesita (`INotificador`, `ILogger`).

### 🔹 D – Dependency Inversion Principle
- `ServicioNotificacion` **depende de abstracciones** (`INotificador`, `ILogger`), no de implementaciones concretas.

---

## ▶️ Ejemplo de Uso

```csharp
var usuario = new Usuario
{
    Nombre = "Ana",
    Email = "ana@mail.com",
    Telefono = "5555"
};

INotificador notificador = new NotificadorEmail(); // o SMS, WhatsApp, etc.
ILogger logger = new LoggerArchivo();

var servicio = new ServicioNotificacion(notificador, logger);
servicio.Ejecutar(usuario, "Hola Ana");
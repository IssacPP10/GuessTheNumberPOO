# 🎮 Adivina el Número (GuessTheNumberPOO)

Un sencillo juego de consola en C# diseñado para practicar los principios de Programación Orientada a Objetos (POO). En este juego, el sistema "piensa" un número aleatorio, y tu objetivo es adivinarlo con la menor cantidad de intentos posible. Cada vez que ingreses un número, el sistema te dará pistas indicando si el número que pensaste es mayor o menor que el objetivo.

---

## 📝 Reglas del Juego

1. El sistema genera un número aleatorio entre 1 y 100.
2. Tú introduces un número que crees que es el correcto.
3. El sistema responde:
   - "El número es mayor" si tu respuesta es menor al número objetivo.
   - "El número es menor" si tu respuesta es mayor al número objetivo.
4. Continúas ingresando números hasta que aciertes.
5. Cuando aciertes, el sistema te felicitará y te mostrará la cantidad de intentos realizados.

---

## 🌟 Características

- **Juego interactivo**: Recibes retroalimentación inmediata sobre tus respuestas.
- **Contador de intentos**: Lleva registro del número de intentos realizados.
- **Diseñado con POO**: El código utiliza clases y objetos para estructurar el programa de manera limpia y modular.

---

## 📚 Tecnologías utilizadas

- **C#**: Lenguaje de programación principal.
- **.NET**: Framework utilizado para ejecutar el programa.
- **Consola**: Interfaz de usuario para la interacción con el juego.

---

## 🛠️ Cómo ejecutar el juego

### 1️⃣ Clonar el repositorio

```bash
git clone https://github.com/tu-usuario/adivina-el-numero.git
cd adivina-el-numero
```

### 2️⃣ Abrir el proyecto en tu IDE

- Abre el archivo del proyecto (`.csproj`) en un IDE compatible con C# como **Visual Studio** o **Visual Studio Code**.

### 3️⃣ Compilar y ejecutar

- En Visual Studio, selecciona la opción "Ejecutar".
- Si usas la terminal, ejecuta:

```bash
dotnet run
```

---

## 🖥️ Ejemplo de juego

```plaintext
¡Bienvenido a Adivina el Número!
He pensado un número entre 1 y 100.
¿Puedes adivinarlo?

Ingresa tu número: 50
El número es mayor.

Ingresa tu número: 75
El número es menor.

Ingresa tu número: 62
¡Correcto! Adivinaste el número en 3 intentos.
```

---

## 🧑‍💻 Contribuir al proyecto

Si deseas mejorar este proyecto o añadir nuevas funcionalidades, sigue estos pasos:

### 1️⃣ Crea una rama nueva

```bash
git checkout -b feature/nueva-funcionalidad
```

### 2️⃣ Realiza tus cambios

Edita el código y realiza los cambios necesarios. Luego, guarda y haz commit:

```bash
git add .
git commit -m "Descripción de los cambios realizados"
```

### 3️⃣ Envía tu rama al repositorio

```bash
git push origin feature/nueva-funcionalidad
```

### 4️⃣ Abre un pull request

Desde GitHub, crea un pull request para que tus cambios sean revisados.

---

## 💡 Ideas para futuras mejoras

- Agregar niveles de dificultad (fácil, medio, difícil).
- Incluir un límite de intentos para aumentar el desafío.
- Guardar el historial de partidas en un archivo.
- Crear una interfaz gráfica para el juego.

---

¡Gracias por interesarte en este proyecto! Si tienes preguntas o sugerencias, no dudes en abrir un **Issue** en el repositorio. 🎉

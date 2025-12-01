# Aplicación de Consola en C# - Procesador de Datos

## Descripción del Proyecto
Esta es una aplicación de consola desarrollada en C# que permite realizar operaciones con diferentes tipos de datos: números enteros, cadenas de texto y arreglos. La aplicación cuenta con un menú interactivo modular que facilita la navegación entre las distintas funcionalidades.

## Características Principales
- **Interfaz de menú interactiva** con control de errores de entrada
- **Procesamiento modular** separado por tipo de dato
- **Manejo de excepciones** para entradas inválidas
- **Resultados claros** con confirmaciones visuales

## Estructura del Proyecto
```
Proyecto/
│
├── Program.cs              # Punto de entrada principal
├── Menus.cs                # Lógica del sistema de menús
├── ProcesarEnteros.cs      # Operaciones con números enteros
├── ProcesarStrings.cs      # Operaciones con cadenas de texto
├── ProcesarArreglos.cs     # Operaciones con arreglos
└── README.md               # Este archivo
```

## Funcionalidades por Módulo

### 1. **Módulo de Enteros**
- Suma, resta, multiplicación y división de números enteros
- Operaciones especiales:
  - Valor absoluto
  - Elevar al cuadrado
  - Verificar si es par o impar
  - Verificar si es positivo o negativo

### 2. **Módulo de Strings**
- **Concatenar**: Unir dos textos en uno solo
- **Buscar**: Localizar palabras dentro de un texto y contar sus vocales
- **Formato**: Convertir texto a mayúsculas o minúsculas

### 3. **Módulo de Arreglos**
- **Crear arreglo**: Definir tamaño y elementos personalizados
- **Ordenar arreglo**: Organizar elementos de menor a mayor
- **Buscar elemento**: Encontrar elementos específicos dentro del arreglo
- **Unir y arreglar**: Combinar dos arreglos y ordenar el resultado

## Cómo Ejecutar
1. Asegúrate de tener instalado el SDK de .NET
2. Clona o descarga el proyecto
3. Navega a la carpeta del proyecto en la terminal
4. Ejecuta: `dotnet run`
5. Sigue las instrucciones en pantalla para navegar por los menús

## Autores
- **Instructor**: Luis Fernando Sánchez
- **Aprendices**:
  - Simon Sierra Lopez
  - Juan Jose Giraldo Monsalve
  - José Manuel Ruiz Zapata

**Software – Ficha 3144585**  
**Medellín – Antioquia – 2025**

## Posibles Mejoras Futuras
1. Agregar persistencia de datos (guardar resultados en archivos)
2. Implementar operaciones con números decimales
3. Añadir interfaz gráfica adicional
4. Incorporar pruebas unitarias
5. Agregar exportación de resultados a diferentes formatos

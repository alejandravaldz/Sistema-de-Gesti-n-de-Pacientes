# 🏥 **Sistema de Gestión de Pacientes**

---

## 📚 **Información del Proyecto**

| Campo | Detalle |
|-------|----------|
| **Universidad** | Universidad Central del Este (UCE) |
| **Asignatura** | Programación Básica |
| **Profesor** | Gamalier Reyes del Carmen |
| **Proyecto** | Sistema de Gestión de Pacientes |
| **Lenguaje** | C# |
| **Tecnología** | Windows Forms (.NET) |
| **Modalidad** | Trabajo en grupo |

---

## 👥 **Integrantes**

- Alejandra Maciel Valdez Morales — 2026-0028  
- Danyi Daniela Aquino Gómez — 2026-0808  
- Loandian Reinaldo Travieso Mota — 2026-0672 
- Milangel Aponte Santana — 2026-0225  
- Starlin Javier Guzmán Sabino — 2026-0311

---

## 🩺 **Descripción del Proyecto**

El **Sistema de Gestión de Pacientes** es una aplicación de escritorio desarrollada en **C#** con **Windows Forms**, diseñada para facilitar el registro y manejo de la información de los pacientes de un centro de salud.

Permite **registrar, consultar, buscar, actualizar y eliminar** pacientes utilizando una lista dinámica `List<Paciente>` para almacenar temporalmente los datos durante la ejecución.  
Incluye validaciones, manejo de excepciones, enumeraciones y principios de **programación orientada a objetos (POO)**.

---
## 🎯 **Objetivo**

Desarrollar una aplicación de escritorio que permita gestionar información de pacientes aplicando los conocimientos de **Programación Básica**, especialmente en **POO**, **listas dinámicas**, **Windows Forms**, **validaciones**, **excepciones** y **enumeraciones**.

---
## 🛠️ **Tecnologías Utilizadas**

- C#  
- .NET  
- Windows Forms  
- Programación Orientada a Objetos  
- List\<T\>  
- Enumeraciones (`enum`)  
- Validaciones y manejo de excepciones
  
---

## ⚙️ **Funcionalidades Principales**

- Registrar nuevos pacientes  
- Listar pacientes registrados  
- Buscar por ID o nombre  
- Actualizar datos del paciente  
- Eliminar registros  
- Validar información ingresada  
- Mostrar mensajes de confirmación y error  
- Manejar excepciones con `try/catch/finally`  
- Utilizar enumeraciones para valores predefinidos  
- Salir del sistema  

> Estas funciones implementan las operaciones CRUD requeridas para el proyecto.

---

## 📝 **Datos de Entrada**

El sistema permite ingresar información mediante los controles de la interfaz:

- Cédula o ID  
- Nombre completo  
- Edad  
- Sexo  
- Diagnóstico  
- Estado del paciente  
- Fecha de ingreso  

> Todos los datos son validados para evitar errores o duplicados.

---

## 🔄 **Procesamiento de Datos**

El programa gestiona la información almacenada en una lista dinámica `List<Paciente>` y realiza:

- Validación de datos  
- Registro y actualización  
- Búsqueda por ID o nombre  
- Eliminación de pacientes  
- Manejo de errores y excepciones  

> La información se mantiene en memoria durante la ejecución.

---

## 📤 **Datos de Salida**

Los resultados se muestran mediante:

- **DataGridView:** visualización de pacientes registrados  
- **MessageBox:** confirmaciones, advertencias y errores  
- **Formularios:** para modificar y consultar información  

---

## 📂 **Organización del Proyecto**

El proyecto se estructura con clases y métodos específicos:

- **Clase `Paciente`:** representa la información del paciente.  
- **Clase de gestión:** maneja las operaciones CRUD sobre la lista.  
- **Formularios:** gestionan la interacción con el usuario.

---


## 🖼️ **Captura de Ejecución**


### 🏠 Menú Principal
![Menú Principal](https://github.com/user-attachments/assets/b378f03f-c42f-450d-9f41-ae798f989e27)

---

### 🧑‍⚕️ Registro Paciente
<br>
*Formulario con los datos de un nuevo paciente antes de guardar.*
<br>
<img width="1816" alt="Formulario de registro" src="https://github.com/user-attachments/assets/d1fc4a87-a7ef-4fa4-805a-f95d960bdf0c" />

*Formulario completado, listo para registrar.*
<br>
<img width="1806" alt="Formulario completado" src="https://github.com/user-attachments/assets/2b4e2b62-795f-48d6-83d5-008d30f2837a" />
<br>
*Mensaje de confirmación tras registrar correctamente.*
<br>
<img width="1812" alt="Mensaje de confirmación" src="https://github.com/user-attachments/assets/b7d23d53-2af5-487d-90dd-6081bf24fbfe" />
<br>
*Si el usuario selecciona "Aceptar", se le pregunta si desea registrar otro paciente.*
<br>
<img width="1805" alt="Pregunta registrar otro paciente" src="https://github.com/user-attachments/assets/4a2852ad-a02c-4682-bab4-f7bbbff41526" />
<br>
*Si el usuario no desea registrar más pacientes, es enviado al menú principal.*
<br>
<img width="1630" alt="Regreso al menú principal" src="https://github.com/user-attachments/assets/48c17c36-23e1-4221-9d5b-a36d4681d9fc" />
<br>
<br>
#### ✅ Validaciones: campo obligatorio vacío / cédula duplicada
<br>
*Campo obligatorio vacío.*
<br>
<img width="1729" alt="Validación campo vacío" src="https://github.com/user-attachments/assets/f3e90191-d693-4632-ad19-617ad5ddb042" />

*Cédula duplicada.*
<br>
<img width="1789" alt="Validación cédula duplicada" src="https://github.com/user-attachments/assets/9805139e-1e6d-43dd-9ad6-1eb4379be75b" />
<br>
---

### 📋 Listar Pacientes

*DataGridView mostrando todos los pacientes registrados.*

<br>
<br>
---

### 🔍 Buscar Paciente
<br>
*Resultado de la búsqueda de un paciente específico.*
<br>
<img width="1806" alt="Resultado de búsqueda" src="https://github.com/user-attachments/assets/e7034d93-adde-4c9d-bc58-4391c332ecb8" />
<br>
*Mensaje que pregunta si desea buscar otro registro de paciente.*
<br>
<img width="1800" alt="Buscar otro paciente" src="https://github.com/user-attachments/assets/4948f2ee-408e-4e43-9222-5f7e9ddb407a" />
<br>
*Mensaje de error cuando la cédula no existe.*
<br>
<img width="1804" alt="Error cédula no existe" src="https://github.com/user-attachments/assets/f18693b9-8ffc-4668-8c10-bd6a94bd9ea9" />
<br>
---
<br>
### ✏️ Modificar o Actualizar Paciente
<br>
*Si el usuario hace clic en el botón antes de escribir la cédula del paciente, se muestra un mensaje de instrucción.*
<br>
<img width="1781" alt="Mensaje instrucción sin cédula" src="https://github.com/user-attachments/assets/c3f99855-2171-4f22-aebd-e367b0a92135" />
<br>
*Formulario con los datos del paciente cargados para editar, junto con la instrucción.*
<br>
<img width="1798" alt="Formulario cargado para editar" src="https://github.com/user-attachments/assets/eb2c398a-e8b8-4400-9913-f407844e19b5" />
<br>
*Si el usuario hace clic nuevamente en el botón "Modificar", se muestra un mensaje y se actualizan los datos.*
<br>
<img width="1796" alt="Mensaje datos modificados" src="https://github.com/user-attachments/assets/bb720cff-abc3-46d7-a5dc-8e10511ad911" />
<br>
<img width="1796" alt="Datos actualizados en la tabla" src="https://github.com/user-attachments/assets/cadab7c1-7331-483f-8b52-d8087decf02a" />

---

### 🗑️ Eliminar Paciente

*MessageBox de confirmación Sí/No antes de eliminar.*
<br>
<img width="1801" alt="Confirmación de eliminación" src="https://github.com/user-attachments/assets/65844d3d-2b3e-4580-889f-b088d7c12121" />
<br>
*Mensaje tras eliminar correctamente al paciente.*
<br>
<img width="1830" alt="Mensaje eliminación exitosa" src="https://github.com/user-attachments/assets/2917749a-6d2f-42d8-81ba-9c5de2f3ad0a" />
<br>
*Resultado tras la eliminación.*
<br>
<img width="1729" alt="Resultado tras eliminar" src="https://github.com/user-attachments/assets/7b0cbaa8-6a33-4970-b252-661a214c2914" />

<br>
---

### 🚪 Salir de la Aplicación
<br>
*MessageBox de confirmación Sí/No antes de salir.*
<br>
<img width="1816" alt="Confirmación de salida" src="https://github.com/user-attachments/assets/3554cd2d-aacb-450c-9ba9-d3b42323e224" />


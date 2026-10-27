# GTools - Software de Gestión y Tarificación Automatizada para Servicio Técnico y Telefonía

[![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=c-sharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET%208.0-512BD4?style=flat-square&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Windows](https://img.shields.io/badge/Windows-0078D6?style=flat-square&logo=windows&logoColor=white)](https://www.microsoft.com/windows)
[![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=flat-square&logo=visual-studio&logoColor=white)](https://visualstudio.microsoft.com/)

Aplicación de escritorio desarrollada en **C# y .NET 8.0 (Windows Forms)** como solución a medida para la optimización de procesos de venta, tarificación de terminales y elaboración automatizada de presupuestos de reparación de dispositivos móviles.

---

## 💼 Contexto y Caso de Negocio

En el entorno de un comercio local de telecomunicaciones y servicio técnico, la elaboración manual de presupuestos generaba tiempos de espera innecesarios en mostrador y discrepancias en la aplicación de tarifas:
* Los costes de repuestos mayoristas variaban con frecuencia.
* Había que calcular márgenes comerciales, canon digital, impuestos e incentivos de fidelización sobre la marcha.
* Existía riesgo de error humano al trasladar las cifras a los presupuestos comunicados a los clientes.

**GTools** se diseñó e implantó como herramienta interna para estandarizar los márgenes de negocio, acelerar la atención en tienda y permitir generar cotizaciones exactas en cuestión de segundos.

---

## ⚡ Características Principales

### 1. Cotizador de Venta de Terminales (`FormPTerminal`)
* Cálculo automático del Precio de Venta al Público (PVP) a partir del coste base mayorista del terminal.
* Aplicación de márgenes comerciales y sumatorio regulatorio del **Canon Digital**.
* **Algoritmo de redondeo psicológico:** Ajuste automático de terminaciones (.4 / .9) para una presentación comercial óptima en mostrador.

### 2. Presupuestador de Servicio Técnico y Reparación (`PReparacion`)
* Cálculo de presupuestos de reparación según coste de componente/pantalla/batería.
* Descuentos configurables por cliente habitual o primera reparación.
* Exportación directa al portapapeles de Windows (`ClipboardHelper`) con formato estructurado para enviar al cliente por WhatsApp o mensajería con un solo clic.

### 3. Sistema de Licenciamiento Criptográfico
* Vinculación de seguridad a máquina mediante hash de la dirección MAC del adaptador de red (`NetworkInterface` y `BigInteger`).
* Validación y verificación de licencias cifradas con AES, incluyendo control de fecha de expiración y cálculo de días de validez restantes.

### 4. Parametrización y Ajustes (`FormAjustes`)
* Módulo de configuración para que el personal autorizado pueda ajustar márgenes de beneficio, porcentaje de canon y reglas de tarificación sin recompilar el código, persistiendo los datos en `config.txt`.

---

## 🛠️ Stack Tecnológico

* **Lenguaje:** C# (C Sharp)
* **Plataforma:** .NET 8.0 Windows Forms
* **Seguridad & Criptografía:** `System.Security.Cryptography`, `System.Numerics`
* **Entorno de compilación:** Visual Studio / .NET SDK 8.0+

---

## 🚀 Compilación y Ejecución en Local

### Requisitos previos
* Sistema Operativo: Windows 10 / 11
* [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) o superior instalado.

### 1. Clonar el repositorio
```bash
git clone https://github.com/Jezuh05/gtools.git
cd gtools
```

### 2. Compilar la solución
```bash
dotnet build
```

### 3. Ejecutar la aplicación
```bash
dotnet run --project GTools
```

---

## 👨‍💻 Autor
Desarrollado por **Jesús Mariano Núñez Fernández**.
Proyecto interno de software a medida aplicado a comercio de telefonía y soporte informático.

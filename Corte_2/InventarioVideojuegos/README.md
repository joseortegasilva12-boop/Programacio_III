# 🎮 Sistema de Inventario de Videojuegos
## Ejercicio Integrador — Programación III (C# Windows Forms)

---

## 📂 Estructura del Proyecto

```
InventarioVideojuegos/
├── Program.cs
├── InventarioVideojuegos.csproj
├── FormPrincipal.cs / .Designer.cs
├── FormProductos.cs / .Designer.cs
├── FormEntradas.cs / .Designer.cs
├── FormSalidas.cs / .Designer.cs
└── FormInformes.cs / .Designer.cs
```

---

## 🗃️ Archivos CSV generados en tiempo de ejecución

| Archivo | Cabecera |
|---|---|
| `videojuegos.csv` | `Codigo,Nombre,Genero,Plataforma,Precio,StockInicial` |
| `entradas.csv` | `Fecha,CodigoProducto,Cantidad,Observacion` |
| `salidas.csv` | `Fecha,CodigoProducto,Cantidad,Observacion` |

**Ejemplo videojuegos.csv:**
```
Codigo,Nombre,Genero,Plataforma,Precio,StockInicial
VJ001,The Last of Us Part I,Aventura,PlayStation 5,299900,10
VJ002,FIFA 25,Deportes,PC,199900,20
VJ003,Minecraft,Simulación,Nintendo Switch,99900,15
```

---

## 🖥️ Formularios

### Form 1: FormPrincipal
- Menú de navegación con `TableLayoutPanel` (1 fila × 4 columnas)
- Botones con `FlatStyle = Flat` + icono emoji + texto
- Abre formularios hijos con `new FormXxx().Show()` (no bloquea)
- `StatusStrip` con versión

### Form 2: FormProductos
- `SplitContainer`: Panel izquierdo = registro, Panel derecho = listado
- `GroupBox` para agrupar secciones
- `TableLayoutPanel` para alinear etiquetas e inputs
- `ComboBox` para Género y Plataforma
- `NumericUpDown` para Stock Inicial
- `DataGridView` con `ReadOnly = true`, `SelectionMode = FullRowSelect`
- Persistencia con `File.AppendAllText` y lectura con `File.ReadAllLines`
- Botón eliminar con confirmación `MessageBox`

### Form 3: FormEntradas
- Selección de videojuego mediante `ComboBox` cargado desde `videojuegos.csv`
- `NumericUpDown` para cantidad (mínimo 1)
- Guarda en `entradas.csv` con fecha actual (`DateTime.Now`)
- Historial en `DataGridView`

### Form 4: FormSalidas
- Al cambiar el `ComboBox`, calcula y muestra el **stock disponible** en tiempo real
- Fórmula: `stockActual = StockInicial + Σ(entradas) − Σ(salidas)`
- Si `cantidadSolicitada > stockActual` → `MessageBox.Show(..., MessageBoxIcon.Warning)` y NO escribe en CSV
- Historial en `DataGridView`

### Form 5: FormInformes
- Resumen en 3 paneles: Total entradas / Total salidas / Videojuegos con stock bajo
- Filtro por videojuego (`ComboBox`) y tipo de movimiento
- `DataGridView` de movimientos con colores: verde = entrada, rojo = salida
- Tabla de stock actual por producto (calculado leyendo los 3 CSV)
- `StatusStrip` con contadores

---

## ⚙️ Componentes utilizados (según requisitos)

| Componente | Usado en |
|---|---|
| `TableLayoutPanel` | FormPrincipal (botones), FormProductos/Entradas/Salidas (campos) |
| `SplitContainer` | FormProductos, FormEntradas, FormSalidas |
| `GroupBox` | Todos los formularios hijos |
| `Panel` | Header azul claro en todos los forms |
| `DataGridView` | ReadOnly=true, SelectionMode=FullRowSelect |
| `NumericUpDown` | Campo de cantidad en Entradas y Salidas |
| `ComboBox` | Género, Plataforma, filtros en Informes |
| `StatusStrip` + `ToolStripStatusLabel` | Todos los formularios |

---

## 🚀 Cómo compilar y ejecutar

**Requisitos:** .NET 6 SDK en Windows

```bash
cd InventarioVideojuegos
dotnet run
```

O abrir el `.csproj` en Visual Studio 2022 y presionar F5.

---

## 🎯 Lógica de validación de stock (FormSalidas)

```csharp
int stockActual = stockInicial + totalEntradas - totalSalidas;

if (cantidadSolicitada > stockActual)
{
    MessageBox.Show("Stock insuficiente.", "Stock insuficiente",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
    return; // NO se escribe en el CSV
}
```

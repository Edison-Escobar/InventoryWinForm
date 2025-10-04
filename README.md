# InventoryWinForm

Gestión de Inventarios en WinForms

📌 Descripción del Proyecto
Este proyecto fue desarrollado como parte del curso **Programación II** en la Universidad San Pablo de Guatemala.  
El sistema consiste en una aplicación de escritorio construida en C# con Windows Forms que permite gestionar inventarios de manera modular.  

Entre sus principales características se encuentran:  
1. Módulo de Categorías
- Crear, editar y eliminar categorías.
- No permite eliminar categorías que tengan productos asociados.
- Se muestran todas las categorías en un DataGridView.

2. Módulo de Productos
- Permite registrar productos asociados a una categoría.
- Cada producto incluye nombre, precio y stock inicial.
- Validaciones:
  - Precio mayor que 0.
  - Stock no negativo.
  - Categoría obligatoria.
- Los productos se muestran en un DataGridView con opción de editar o eliminar.

3. Módulo de Movimientos
- Registra *entradas* y *salidas* de productos.
- No permite salidas si no hay stock suficiente.
- Guarda historial de movimientos con fecha, tipo y cantidad.


La aplicación fue diseñada para aplicar *Programación Orientada a Objetos (POO)*, validaciones de datos, diseño de interfaces gráficas y trabajo colaborativo en repositorios.

Integrantes del Grupo
- Roberth Alexander Melendez Sicaja – 2500461  
- Edison Adrian Escobar Pérez – 2500446  

🔗 Repositorio en GitHub
Puedes acceder al código fuente del proyecto en el siguiente enlace:  
👉 [InventoryWinForm - GitHub](https://github.com/Edison-Escobar/InventoryWinForm)

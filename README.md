# Configuración de SQL Server para Conexiones Externas

Si se utilizó la instalación por defecto de **SQL Server**, es necesario realizar los siguientes pasos para permitir conexiones externas, especialmente si se desea conectar desde otras aplicaciones o entornos como MySQL Server.

## 1. Habilitar protocolo TCP/IP

1. Abre **SQL Server Configuration Manager**.
2. En el panel izquierdo, selecciona:  
   `SQL Server Network Configuration > Protocols for SQLEXPRESS` (o la instancia correspondiente).
3. En el panel derecho, haz doble clic en **TCP/IP**.
4. En la ventana de propiedades, cambia la opción a `Yes`.
5. Haz clic en **OK**.
6. Reinicia el servicio de SQL Server para aplicar los cambios.

## 2. Activar el modo de autenticación mixta (Windows y SQL Server)

1. Abre **SQL Server Management Studio (SSMS)**.
2. Conéctate al motor de base de datos usando autenticación de Windows.
3. En el Explorador de objetos, haz clic derecho sobre el servidor (nombre del servidor).
4. Selecciona **Properties**.
5. En la ventana emergente, ve a la pestaña **Security**.
6. Selecciona la opción **SQL Server and Windows Authentication mode**.
7. Haz clic en **OK**.
8. Reinicia nuevamente el servicio de SQL Server para que los cambios surtan efecto.

## Notas adicionales

- Verifica que el puerto **TCP 1433** esté habilitado si se usa una instancia predeterminada.

---

Con esta configuración, SQL Server estará preparado para aceptar conexiones tanto locales como remotas, utilizando autenticación mixta y el protocolo de red adecuado.

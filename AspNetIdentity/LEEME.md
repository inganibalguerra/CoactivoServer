# ProyectoCapas

Cuenta HotMail del cliente SMTP para el envío de correos:

**Nombre**: Cobro Coactivo
**Email**: tais2coactivo@hotmail.com
**Contraseña**: electiva2taisII.

## Operaciones

Crear un usuario para obtener un Token:

```
{ 
  "Email": "mr.elliotalderson@hotmail.com", 
  "Username":"3lliot@ld3rs0n", 
  "Password": "unDiaSol3@do.", 
  "ConfirmPassword": "unDiaSol3@do.", 
  "FirstName": "Elliot", 
  "LastName": "Alderson"
}
```

### Antes de guardar una factura debo tener un cliente:

```
{
  "Direccion": "Calle 30 No. 30-17",
  "Nombre": "Duvan Palmera",
  "Telefono": "3003432858"
}
```

### Crear una factura (sin Items):

```
{
  "Fecha": "2016-11-24",
  "NumeroFactura": "723",
  "ClienteId": 
}
```

### Guardar una factura con los item incluidos desde el cliente REST

```
{
  "Fecha": 1480002326532,
  "NumeroFactura": "324",
  "ClienteId": 1,
  "ItemFacturas": [
    {
      "Descripcion": "Computador Lenovo i3",
      "Valor": 1050000,
      "Cantidad": 2,
      "Iva": 336000
    },
    {
      "Descripcion": "Disco Duro Externo TOSHIBA 1TB",
      "Valor": 232000,
      "Cantidad": 3,
      "Iva": 111360
    },
  ]
}
```

Para guardar un proyecto:

```
{ 
  "ClienteId": 4009, 
  "Nombre": "anibaljoseguerraz@gmail.com", 
  "Valor":"23", 
  "FechaInicio": "2016-11-10", 
  "Plazo": "2", 
  "Estado": "Pendiente",
  "Lista":[{
    "FechaPago":"2016-11-11",
    "Valor":"23",
    "Estado":"LISTO",
    "FacturaId":"1"
  }]
}
```

## Comandos:

- `enable-migrations`: habilitar las migraciones en el proyecto.
- `add-migration InitialCreate`: así se crea un migración.
- `update-database`: para aplicar las migraciones en la base de datos.
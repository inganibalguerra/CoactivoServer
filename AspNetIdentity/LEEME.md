# ProyectoCapas

Cuenta HotMail del cliente SMTP para el envío de correos:

**Nombre**: Cobro Coactivo
**Email**: tais2coactivo@hotmail.com
**Contraseña**: electiva2taisII.

## Operaciones

Crear un usuario para obtener un Token:

```
{
  "CreateUserBindingModel":{ 
    "UserName":"anibal1", 
    "Password": "Anibal11*", 
    "ConfirmPassword": "Anibal11*", 
    "RoleName":"Abogado"
  },
  "Persona":{
    "Apellidos":"Mindiola",
    "Direccion":"Carrera 13 # 36 - 111",
    "Identificacion":"1065824563",
    "Nombres":"Maira mindiola",
    "Sexo":"F",
    "Email":"anibaljose.15@hotmail.com",
    "Nacionalidad":"Colombia",
    "PaisNacimiento":"Colombia",
    "PaisCorrespondencia":"Colombia",
    "Departamento":"Cesar",
    "Municipio":"Pueblo Bello",
    "FechaNacimiento":"1996-07-30",
    "TipoPersonaId":1,
    "Telefono":"3215843514"
  }
}
```

### Historia de usuario N° 1, Para el Registro de los datos de los deudores
{
  "Cuantia":525000,
  "Dueda":525000,
  "Estado":"Por autorizar",
  "FechaPreinscripcion":"2017-03-09",
  "TipoObligacionId":1,
  "Persona":{
    "Apellidos":"Mindiola",
    "Direccion":"Carrera 13 # 36 - 111",
    "Identificacion":"1065824563",
    "Nombres":"Maira mindiola",
    "Sexo":"F",
    "Email":"anibaljose.14@hotmail.com",
    "Nacionalidad":"Colombia",
    "PaisNacimiento":"Colombia",
    "PaisCorrespondencia":"Colombia",
    "Departamento":"Cesar",
    "Municipio":"Pueblo Bello",
    "FechaNacimiento":"1996-07-30",
    "TipoPersonaId":1,
    "Telefono":3186875411
  },
  "Expediente":{
    "Cuantia":525000,
    "Descripcion":"Esto es una descripcion",
    "DireccionEjecutado":"Esto es una direccion",
    "DireccionTituloEjecutivo":"Esto es una direcciond e titulo ejecutivo",
    "EntidadEncargada":"Entidad encargada es maira",
    "FechaRadicacion":"2017-03-19",
    "Identificacion":"1065824563",
    "NaturalezaObligacion":"Naturaleza es algo",
    "Nombre":"Maira mindiola",
    "UbicacionExpediente":"Esta en el lote tal"
  }
}

## Comandos:

- `enable-migrations`: habilitar las migraciones en el proyecto.
- `add-migration InitialCreate`: así se crea un migración.
- `update-database`: para aplicar las migraciones en la base de datos.
const conectar=require('../db_conexion.js');
const {Router} = require('express');
const router = Router();

const employees=[
{id:1,
    Nombres:'Juan',
    Apellidos:'Perez',
    Direccion:'Quetzaltenango',
    Telefono:'12345678',
    DPI: '1234567890123',
    Genero: 'Masculino',
    FechaNacimiento: '1999-10-10',
    Fecha_Inicio_Labores: '2022-01-01',
    FechaIngreso: '2022-01-01'},
{id:2,
        Nombres:'Maria',
        Apellidos:'Juarez',
        Direccion:'Chimaltenango',
        Telefono:'12345678',
        DPI: '1234567890123',
        Genero: 'Masculino',
        FechaNacimiento: '1999-01-01',
        FechaInicioLabores: '2022-05-05',
        FechaIngreso: '2023-05-05'}
]

router.get ('/api/product', (req, res) => {
    conectar.query('select idEmpleado,Nombre,Apellidos,Direccion,Telefono,DPI,Genero,Fecha_Nacimiento,Fecha_Inicio_Labores,Fecha_Ingreso from empleados', (error,filas)=>{
        if(error){
            res.status(403).send('Error en empleados');
        }else{
            res.json(filas);
        }
    });
    
    
});

router.post ('/api/employee', (req, res) => {
    const empleados = {
        id: employees.length + 1,
        Nombres: req.body.Nombres,
        Apellidos: req.body.Apellidos,
        Direccion: req.body.Direccion,
        Telefono: req.body.Telefono,
        DPI: req.body.DPI,
        Genero: req.body.Genero,
        FechaNacimiento: req.body.FechaNacimiento,
        FechaInicioLabores: req.body.FechaoresInicioLab,
        FechaIngreso: req.body.FechaIngreso
    };
    products.push(empleados);
    res.send(empleados);
});

router.put ('/api/product/:id', (req, res) => {
    const empleados = employees.find(c => c.id === parseInt(req.params.id));
    if (!empleados) res.status(403).send('The product with the given ID was not found.');
    empleados.Nombres = req.body.Nombres;
    res.send(empleados);
});

router.delete ('/api/product/:id', (req, res) => {
    const empleados = employees.find(c => c.id === parseInt(req.params.id));
    if (!empleados) res.status(403).send('The product with the given ID was not found.');
    const index = employees.indexOf(empleados);
    employees.splice(index, 1);
    res.send(empleados);
});



module.exports = router;
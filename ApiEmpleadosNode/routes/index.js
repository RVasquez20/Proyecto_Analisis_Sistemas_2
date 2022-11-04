const config=require('../db_conexion.js');
const mssql=require('mssql');
const {Router} = require('express');
const router = Router();

router.get ('/Empleados',async  (req, res) => {
    let  pool = await  mssql.connect(config);
    let  products = await  pool.request().query("SELECT * FROM Empleados;");
    return  res.json(products.recordsets);

});

module.exports = router;
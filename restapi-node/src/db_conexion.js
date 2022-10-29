const mssql=require('mssql');
const conectar=mssql.createConnection({
    host:'localhost',
    user:'usr_panaderia',
    password:'12345',
    database:'panaderia_el_buen_pan'
});
conectar.connect(function(error){
    if(error){
        throw error;
    }else{
        console.log('Conexion exitosa');
    }
});
module.exports=conectar;
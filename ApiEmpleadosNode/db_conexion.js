const mssql=require('mssql');
const  config = {
    user:  'admin_pan', // sql user
    password:  '^"D6EKJ4KA2aAj48', //sql user password
    server:  'panaderia-el-buen-pan.database.windows.net', // if it does not work try- localhost
    database:  'Panaderia_ElBuenPan',
    port:  1433
  }
  
module.exports=config;
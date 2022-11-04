package com.umg.apispring.controlles;


import com.umg.apispring.dao.UsuariosDAO;
import com.umg.apispring.modelos.Usuario;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Optional;

@RestController
public class ManejoUsuarioController {
    @Autowired
    private UsuariosDAO usuariosDAO;


    @GetMapping(value = "/infoUsuarios")
    public List<Usuario> manejoUsuarios(){

        return usuariosDAO.findAll();
    }
    @GetMapping("/infoUsuarios/{id}")
    public Optional<Usuario> manejoUsuarios(@PathVariable(value = "id")Long id){

        return usuariosDAO.findById(id);
    }

}

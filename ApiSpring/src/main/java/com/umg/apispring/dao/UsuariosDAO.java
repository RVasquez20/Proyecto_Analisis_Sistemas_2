package com.umg.apispring.dao;

import com.umg.apispring.modelos.Usuario;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.repository.CrudRepository;

public interface UsuariosDAO extends JpaRepository<Usuario, Long> {



}

import axios from "axios";
import { Link } from 'react-router-dom';
import { parseJWT, usuarioAutenticado } from "../../services/auth";
import { Component } from "react";

export default class Login extends Component{
  constructor(props){
      super(props);
      this.state={
          email: "adm@gmail.com",
          senha: "adm123",
          erroMensagem: "",
          isLoading: false
      }
  };
render(){
  
}

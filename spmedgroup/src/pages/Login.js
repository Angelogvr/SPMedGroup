import { Component } from "react";
import axios from "axios";
import { Link } from 'react-router-dom';

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
  <div>
    <main>
        <section class="section-logo">
            <img src="../assets/logo_spmedgroup_v1 1.png" alt="Logo SpMedicalGroup">
            <h1>Conecte-se a sua conta SpMedicalGroup:</h1>
            <p>Não tem uma conta? Cadastre-se agora mesmo!</p>
            <a href="">Cadastrar-se</a>
        </section>
        <section class="section-info">
            <div class="box-form">
                <form action="">
                    <div class="margin-input">
                        <p>Email / Nome de Usuário</p>
                        <input type="text">
                    </div>
                    <div class="margin-input">
                        <p>Senha</p>
                        <input type="password">
                    </div>
                    <a href="">Esqueceu sua senha?</a>
                    <button>Login</button>
                </form>
            </div>
        </section>
    </main>
  </div>
}

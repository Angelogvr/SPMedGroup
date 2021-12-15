import { Component } from "react";
import axios from 'axios';
import { Link } from 'react-router-dom';
import { render } from "@testing-library/react";

import '../assets/css/style.css';

export default class Login extends Component {
    constructor(props) {
        super(props);
        this.state = {
            email: '',
            senha: '',
            erroMensagem: '',
            isLoading: false
        }
    };

    efetuaLogin = (event) => {
        event.preventDefault();

        this.setState({ erroMensagem: "", isLoading: true })

        axios.post('http://localhost:5000/api/login', {
            email: this.state.email,
            senha: this.state.senha
        })

            .then(resposta => {
                if (resposta.status === 200) {
                    localStorage.setItem('usuario-login', resposta.data.token);
                    this.setState({ isLoading: false });
                    this.props.history.push('/');
                }
            })
            .catch(() => {
                this.setState({ erroMensagem: "Email e/ou senha inválidos!", isLoading: false });
            })
    }



    atualizaStateCampo = (campo) => {
        this.setState({ [campo.target.name]: campo.target.value })
    }

    render() {
        return (
            <main>
                <section class="section-logo">
                    <img src="logo_spmedgroup_v1 1.png" alt="Logo SpMedicalGroup"></img>
                    <h1>Conecte-se a sua conta SpMedicalGroup:</h1>
                    <p>Não tem uma conta? Cadastre-se agora mesmo!</p>
                    <a href="">Cadastrar-se</a>
                </section>
                <section class="section-info">
                    <div class="box-form">
                        <form action="">
                            <div class="margin-input">
                            <p>Email / Nome de Usuário</p>
                            <input 
                            type="text"
                            name="email"
                            value={this.state.email}
                            onChange={this.atualizaStateCampo}></input>
                        </div>
                        <div class="margin-input">
                            <p>Senha</p>
                            <input 
                            type="password" 
                            name="senha" 
                            value={this.state.senha}
                            onChange={this.atualizaStateCampo}></input>
                        </div>
                        <a href="">Esqueceu sua senha?</a>
                        <button>Login</button>
                        </form>
                    </div>
                </section>
            </main>
        );
    }
}







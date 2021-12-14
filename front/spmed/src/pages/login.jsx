import { Component } from "react";
import axios from 'axios';
import { Link } from 'react-router-dom';
import { render } from "@testing-library/react";

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

    render(){
        return (
            <div>
            <h1>aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</h1>
            </div>
            );
    }
}







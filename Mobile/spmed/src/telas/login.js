import React from 'react';

import {
  SafeAreaView,
  ScrollView,
  StatusBar,
  StyleSheet,
  Text,
  useColorScheme,
  View,
} from 'react-native';

import {
  Colors,
  DebugInstructions,
  Header,
  LearnMoreLinks,
  ReloadInstructions,
} from 'react-native/Libraries/NewAppScreen';

import api from '../services/api';

import AsyncStorage from '@react-native-async-storage/async-storage';

class Login extends Component {
    constructor(props) {
      super(props);
      this.state = {
        email: 'bruno@gmail.com',
        senha: 'bruno123',
      };
    };
  
    realizarLogin = async () => {
      console.warn(this.state.email + ' ' + this.state.senha);
  
      const resposta = await api.post('/Login', {
        email: this.state.email,
        senha: this.state.senha,
      });
  
      const token = resposta.data.token;
      await AsyncStorage.setItem('userToken', token);
  
      if (resposta.status == 200) {
        console.warn("teste")
        this.props.navigation.navigate('Consultas');
      }
  
      console.warn(token);
    };

    render(){
        return{
            
        }
    }
}

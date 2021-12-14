// import 'react-native-gesture-handler';

import React, {Component} from 'react';

import {NavigationContainer} from '@react-navigation/native';
import {createStackNavigator} from '@react-navigation/stack';

import {StatusBar, StyleSheet} from 'react-native';


const AuthStack = createStackNavigator();
import Login from './src/telas/login'





class App extends Component {
  render() {
    return (
      <NavigationContainer>
        <StatusBar
          hidden={true}
        />
        <AuthStack.Navigator
          screenOptions={{
            headerShown: false,
          }}>
          <AuthStack.Screen name="Login" component={Login} />
          <AuthStack.Screen name="Consultas" component={Projetos} />
        </AuthStack.Navigator>
      </NavigationContainer>
  );
  }
};

const styles = StyleSheet.create({
  main: {
    flex: 1,
    backgroundColor: '#F1F1F1',
  },

  tabBarIcon: {
    width: 22,
    height: 22,
  },

});

export default App;

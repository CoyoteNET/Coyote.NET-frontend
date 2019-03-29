import React, { Component } from 'react';
import Header from '../Containers/Header'
import Footer from '../Containers/Footer'
import Home from '../Containers/Home'
import './App.css';


class App extends Component {
  render() {
    return (
      <div>
        <Header />
        <Home />
        <Footer />
      </div>
    );
  }
}

export default App;

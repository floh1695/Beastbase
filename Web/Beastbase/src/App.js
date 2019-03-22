import React, { Component } from "react";
import Navbar from "./components/layout/Navbar";
import RegisterLogin from "./components/RegisterLogin";
import "./App.css";

class App extends Component {
  render() {
    return (
      <div className="App">
        <Navbar />
        <RegisterLogin />
      </div>
    );
  }
}

export default App;

import React, { Component } from "react";
import Navbar from "./components/layout/Navbar";
import RegisterLogin from "./components/RegisterLogin";
import RegisterUser from "./components/forms/RegisterUser";
import LoginUser from "./components/forms/LoginUser";

import "./App.css";

class App extends Component {
  render() {
    return (
      <div className="App">
        <Navbar />
        <RegisterLogin />
        <RegisterUser />
        <LoginUser />
      </div>
    );
  }
}

export default App;

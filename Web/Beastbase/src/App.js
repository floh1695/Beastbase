import React, { Component } from "react";
import { BrowserRouter as Router, Route, Switch } from "react-router-dom";
import Navbar from "./components/layout/Navbar";
import BeastListing from "./components/pages/BeastListing";
import AboutApp from "./components/pages/AboutApp";
import AboutDevs from "./components/pages/AboutDevs";
import Register from "./components/pages/Register";
import Login from "./components/pages/Login";
import RegisterLogin from "./components/RegisterLogin";



import "./App.css";

class App extends Component {
  render() {
    return (
      <Router>
        <div className="App">
          <Navbar />
          <div className="container-fluid">
            <Switch>
              <Route exact path="/" component={RegisterLogin} />
              <Route exact path="/beast-listing" component={BeastListing} />
              <Route exact path="/about-beastbase" component={AboutApp} />
              <Route exact path="/developers" component={AboutDevs} />
              <Route exact path="/register" component={Register} />
              <Route exact path="/login" component={Login} />
            </Switch>
          </div>
        </div>
      </Router>
    );
  }
}

export default App;

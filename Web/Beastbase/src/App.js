import React, { Component } from "react";
import { BrowserRouter as Router, Route, Switch } from "react-router-dom";
import Navbar from "./components/layout/Navbar";
import BeastListing from "./components/pages/BeastListing";
import BeastEntry from "./components/pages/BeastEntry";
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
              <Route exact path="/beastbase/web/" component={RegisterLogin} />
              <Route exact path="/beastbase/web/beast-listing" component={BeastListing} />
              <Route exact path="/beastbase/web/beast-entry" component={BeastEntry} />
              <Route exact path="/beastbase/web/about-beastbase" component={AboutApp} />
              <Route exact path="/beastbase/web/developers" component={AboutDevs} />
              <Route exact path="/beastbase/web/register" component={Register} />
              <Route exact path="/beastbase/web/login" component={Login} />
            </Switch>
          </div>
        </div>
      </Router>
    );
  }
}

export default App;
